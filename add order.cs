using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Login
{
    public partial class add_order : Form
    {
        string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";
        private DataTable inventoryData;
        private string selectedSKU;
        public add_order(
    int orderId, string customerName, string dressSelection, int quantity,
    DateTime orderDate, DateTime deliveryDate, string orderStatus, string paymentStatus,
    decimal totalPrice, string paymentMethod, string specialNotes)
        {
            InitializeComponent();

            // Assign parameters to controls — update control names if different
            txtOrderID.Text = orderId.ToString();
            txtCustomerName.Text = customerName;
            cmbDressSelection.Text = dressSelection;
            txtQuantity.Value = quantity;
            dtpOrderDate.Value = orderDate;
            dtpDeliveryDate.Value = deliveryDate;
            cmbOrderStatus.SelectedItem = orderStatus;
            cmbPaymentStatus.SelectedItem = paymentStatus;
            txtTotalPrice.Text = totalPrice.ToString("F2");
            cmbPaymentMethod.SelectedItem = paymentMethod;
            txtSpecialNotes.Text = specialNotes;

            // Optional: disable editing of order ID if necessary
            txtOrderID.Enabled = false;
        }


        public add_order()
        {
            InitializeComponent();
            LoadForm();
            LoadDressSelection();

            // Wire up event handlers for price update
            cmbDressSelection.SelectedIndexChanged += cmbDressSelection_SelectedIndexChanged;
            txtQuantity.ValueChanged += TxtQuantity_ValueChanged;
        }

        private void LoadDressSelection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT ItemID, ItemName, SellingPrice, SKU FROM Inventory WHERE Category = 'Dress'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDressSelection.DataSource = dt;
                cmbDressSelection.DisplayMember = "ItemName";
                cmbDressSelection.ValueMember = "ItemID";

                inventoryData = dt;
            }
        }
        private void LoadForm()
        {
            txtOrderID.Text = GetNextOrderID().ToString();
            dtpOrderDate.Value = DateTime.Now;
            dtpDeliveryDate.Value = DateTime.Now.AddDays(7);
            dtpOrderDate.Enabled = false;

            cmbOrderStatus.Items.AddRange(new[] { "Pending", "In Progress", "Completed", "Cancelled" });
            cmbPaymentStatus.Items.AddRange(new[] { "Paid", "Unpaid", "Partially Paid" });
            cmbPaymentMethod.Items.AddRange(new[] { "Cash", "Card", "Bank Transfer" });

            LoadDressSelection();
        }


        private int GetNextOrderID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(OrderID), 0) + 1 FROM Orders";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void UpdateTotalPrice()
        {
            if (cmbDressSelection.SelectedIndex >= 0 && inventoryData != null)
            {
                DataRowView selectedRow = cmbDressSelection.SelectedItem as DataRowView;
                if (selectedRow != null && decimal.TryParse(selectedRow["SellingPrice"].ToString(), out decimal price))
                {
                    int quantity = (int)txtQuantity.Value;
                    decimal total = price * quantity;
                    txtTotalPrice.Text = total.ToString("F2");
                }
                else
                {
                    txtTotalPrice.Text = "0.00";
                }
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Customer Name is required.");
                return false;
            }
            if (cmbDressSelection.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a dress.");
                return false;
            }
            if (txtQuantity.Value <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return false;
            }
            if (cmbOrderStatus.SelectedIndex == -1 || cmbPaymentStatus.SelectedIndex == -1 || cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all status and payment options.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTotalPrice.Text) || !decimal.TryParse(txtTotalPrice.Text, out _))
            {
                MessageBox.Show("Enter a valid Total Price.");
                return false;
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void orderdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void orderstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Orders 
                        (CustomerName, DressSelection, Quantity, OrderDate, DeliveryDate, OrderStatus, PaymentStatus, TotalPrice, PaymentMethod, SpecialNotes, SKU)
                    VALUES 
                        (@CustomerName, @DressSelection, @Quantity, @OrderDate, @DeliveryDate, @OrderStatus, @PaymentStatus, @TotalPrice, @PaymentMethod, @SpecialNotes, @SKU)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);

                    // Use SelectedValue (int) for DressSelection
                    cmd.Parameters.AddWithValue("@DressSelection", (int)cmbDressSelection.SelectedValue);

                    cmd.Parameters.AddWithValue("@Quantity", (int)txtQuantity.Value);
                    cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                    cmd.Parameters.AddWithValue("@DeliveryDate", dtpDeliveryDate.Value);
                    cmd.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text);

                    // Parse decimal safely
                    if (decimal.TryParse(txtTotalPrice.Text, out decimal totalPrice))
                    {
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    }
                    else
                    {
                        MessageBox.Show("Invalid total price.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@SpecialNotes", txtSpecialNotes.Text);
                    cmd.Parameters.AddWithValue("@SKU", selectedSKU ?? string.Empty);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order saved successfully.");
                    ClearForm();
                    txtOrderID.Text = GetNextOrderID().ToString();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Enter Order ID to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Orders SET
                        CustomerName = @CustomerName,
                        DressSelection = @DressSelection,
                        Quantity = @Quantity,
                        OrderDate = @OrderDate,
                        DeliveryDate = @DeliveryDate,
                        OrderStatus = @OrderStatus,
                        PaymentStatus = @PaymentStatus,
                        TotalPrice = @TotalPrice,
                        PaymentMethod = @PaymentMethod,
                        SpecialNotes = @SpecialNotes,
                                 SKU = @SKU
                    WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                    cmd.Parameters.AddWithValue("@DressSelection", cmbDressSelection.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Value);
                    cmd.Parameters.AddWithValue("@OrderDate", dtpOrderDate.Value);
                    cmd.Parameters.AddWithValue("@DeliveryDate", dtpDeliveryDate.Value);
                    cmd.Parameters.AddWithValue("@OrderStatus", cmbOrderStatus.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text);
                    cmd.Parameters.AddWithValue("@TotalPrice", decimal.Parse(txtTotalPrice.Text));
                    cmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                    cmd.Parameters.AddWithValue("@SpecialNotes", txtSpecialNotes.Text);
                    cmd.Parameters.AddWithValue("@SKU", selectedSKU ?? string.Empty);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order updated successfully.");
                    ClearForm();
                    txtOrderID.Text = GetNextOrderID().ToString();
                }
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            cmbDressSelection.SelectedIndex = -1;
            txtQuantity.Value = txtQuantity.Minimum;
            dtpOrderDate.Value = DateTime.Now;
            dtpDeliveryDate.Value = DateTime.Now.AddDays(7);
            cmbOrderStatus.SelectedIndex = -1;
            cmbPaymentStatus.SelectedIndex = -1;
            txtTotalPrice.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            txtSpecialNotes.Clear();
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Enter Order ID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order deleted successfully.");
                ClearForm();
                txtOrderID.Text = GetNextOrderID().ToString();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
                {

                }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtDressID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();

        }
        private void cmbDressSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSKU();
        }

        private void TxtQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        private void UpdateSKU()
        {
            if (cmbDressSelection.SelectedIndex >= 0 && inventoryData != null)
            {
                DataRowView selectedRow = cmbDressSelection.SelectedItem as DataRowView;
                if (selectedRow != null && selectedRow["SKU"] != DBNull.Value)
                {
                    selectedSKU = selectedRow["SKU"].ToString();
                }
                else
                {
                    selectedSKU = string.Empty;
                }
            }
            else
            {
                selectedSKU = string.Empty;
            }
        }
    }
}
