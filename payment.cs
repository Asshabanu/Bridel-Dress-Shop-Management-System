using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace Login
{
    public partial class payment : Form
    {
        string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True;TrustServerCertificate=True";
        public payment()
        {
            InitializeComponent();
            LoadOrderIDs();
            GeneratePaymentID();
            SetupDataGridView();

            cmbOrderID.SelectedIndexChanged += cmbOrderID_SelectedIndexChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            txtQty.ValueChanged += txtQty_ValueChanged;
            txtSKU.Leave += txtSKU_Leave;
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("PaymentIDColumn", "Payment ID");
            dataGridView1.Columns.Add("GuestNameColumn", "Guest Name");
            dataGridView1.Columns.Add("OrderIDColumn", "Order ID");
            dataGridView1.Columns.Add("SKUColumn", "SKU");
            dataGridView1.Columns.Add("QtyColumn", "Qty");
            dataGridView1.Columns.Add("AmountColumn", "Amount");
            dataGridView1.Columns.Add("TotalColumn", "Total");
            dataGridView1.Columns.Add("DiscountColumn", "Discount");
            dataGridView1.Columns.Add("FinalPriceColumn", "Final Price");
        }
         private void LoadOrderIDs()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT OrderID FROM Orders", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbOrderID.Items.Clear();

                    while (reader.Read())
                    {
                        cmbOrderID.Items.Add(reader["OrderID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Order IDs: " + ex.Message);
            }
        }
        private void GeneratePaymentID()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(PaymentID) FROM Payments", conn);
                    object result = cmd.ExecuteScalar();
                    int id = 1;
                    if (result != DBNull.Value && result != null)
                    {
                        string lastID = result.ToString();
                        if (lastID.StartsWith("PMT") && int.TryParse(lastID.Substring(3), out int lastNum))
                        {
                            id = lastNum + 1;
                        }
                    }
                    PaymentID.Text = "PMT" + id.ToString("0000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Payment ID: " + ex.Message);
            }
        }
        private void cmbOrderID_Leave(object sender, EventArgs e)
        {
            string orderID = cmbOrderID.Text.Trim();
            if (string.IsNullOrEmpty(orderID))
            {
                ClearForm();
                dataGridView1.Rows.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string guestName = GetGuestName(orderID);

                    if (string.IsNullOrEmpty(guestName))
                    {
                        MessageBox.Show("Order ID not found.");
                        return;
                    }
                    string query = @"
                SELECT I.SKU, I.SellingPrice, O.Quantity
                FROM Orders O
                JOIN Inventory I ON O.SKU = I.SKU
                WHERE O.OrderID = @OrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            bool hasRows = false;

                            while (reader.Read())
                            {
                                hasRows = true;

                                string sku = reader["SKU"]?.ToString() ?? "";
                                decimal price = reader["SellingPrice"] != DBNull.Value ? Convert.ToDecimal(reader["SellingPrice"]) : 0m;
                                int qty = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;

                                decimal total = price * qty;

                                if (dataGridView1.Rows.Count == 0)
                                {
                                    txtSKU.Text = sku;
                                    txtAmount.Text = price.ToString("0.00");
                                    txtQty.Value = qty;
                                    txtTotal.Text = total.ToString("0.00");
                                }

                                dataGridView1.Rows.Add(PaymentID.Text, guestName, orderID, sku, qty, price, total, 0m, total);
                            }

                            if (!hasRows)
                            {
                                MessageBox.Show("No items found for this Order ID.");
                            }
                            else
                            {
                                UpdateTotalAmount();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void LoadPaymentData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                PaymentID,
                                OrderID,
                                SKU,
                                Amount,
                                Qty,
                                Total,
                                GuestName,
                                Discount,
                                FinalPrice
                             FROM Payments";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message);
            }
        }




        private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderID = cmbOrderID.Text;
            if (string.IsNullOrWhiteSpace(selectedOrderID))
            {
                ClearForm();
                dataGridView1.Rows.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string guestName = GetGuestName(selectedOrderID);

                    SqlCommand cmd = new SqlCommand(
                        @"SELECT I.SKU, I.SellingPrice, I.Discount, O.Quantity 
                  FROM Orders O 
                  JOIN Inventory I ON O.SKU = I.SKU 
                  WHERE O.OrderID = @OrderID", conn);
                    cmd.Parameters.AddWithValue("@OrderID", selectedOrderID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    dataGridView1.Rows.Clear();

                    while (reader.Read())
                    {
                        string sku = reader["SKU"].ToString();
                        decimal price = Convert.ToDecimal(reader["SellingPrice"]);
                        int qty = Convert.ToInt32(reader["Quantity"]);
                        decimal discount = reader["Discount"] != DBNull.Value ? Convert.ToDecimal(reader["Discount"]) : 0m;

                        decimal total = price * qty;
                        decimal finalPrice = total - discount;

                        dataGridView1.Rows.Add(PaymentID.Text, guestName, selectedOrderID, sku, qty, price, total, discount, finalPrice);
                    }

                    UpdateTotalAmount();

                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order items: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtSKU.Text = row.Cells["SKUColumn"].Value?.ToString() ?? "";
                txtAmount.Text = Convert.ToDecimal(row.Cells["AmountColumn"].Value).ToString("0.00");
                txtQty.Value = Convert.ToDecimal(row.Cells["QtyColumn"].Value);
                txtTotal.Text = Convert.ToDecimal(row.Cells["TotalColumn"].Value).ToString("0.00");
            }
        }

        private string GetGuestName(string orderID)
        {
            string guest = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT CustomerName FROM Orders WHERE OrderID = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", orderID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                guest = reader["CustomerName"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching guest name: " + ex.Message);
            }
            return guest;
        }

        private void ClearInputs()
        {
            txtSKU.Clear();
            txtAmount.Clear();
            txtQty.Value = 1;
            txtTotal.Clear();
        }
        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && decimal.TryParse(row.Cells["FinalPriceColumn"].Value?.ToString(), out decimal value))
                {
                    total += value;
                }
            }
            txtTotalAmount.Text = total.ToString("0.00");
        }
        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                decimal total = amount * txtQty.Value;
                txtTotal.Text = total.ToString("0.00");
            }
        }

        private void txtSKU_Leave(object sender, EventArgs e)
        {
            string sku = txtSKU.Text.Trim();
            if (string.IsNullOrEmpty(sku))
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT SellingPrice, Discount FROM Inventory WHERE SKU=@sku", conn);
                    cmd.Parameters.AddWithValue("@sku", sku);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal price = Convert.ToDecimal(reader["SellingPrice"]);
                            decimal discount = reader["Discount"] != DBNull.Value ? Convert.ToDecimal(reader["Discount"]) : 0;

                            txtAmount.Text = price.ToString("0.00");
                            // You can optionally show discount somewhere if needed
                        }
                        else
                        {
                            MessageBox.Show("SKU not found.");
                            txtAmount.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving SKU price: " + ex.Message);
            }
        }

        private void qtyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                decimal total = amount * txtQty.Value;
                txtTotal.Text = total.ToString("0.00");
            }
        }

        private void skuTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT SellingPrice FROM Inventory WHERE SKU=@sku", conn))
                    {
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtAmount.Text = Convert.ToDecimal(result).ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("SKU not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving SKU price: " + ex.Message);
            }
        }


        private void payment_Load(object sender, EventArgs e)
        {
        }
        
       
        private void panel7_Paint(object sender, PaintEventArgs e){}
        
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button9_Click(object sender, EventArgs e){ new Login().Show();this.Hide();}
        private void button8_Click_1(object sender, EventArgs e){new reports().Show();this.Hide();}

        private void Add_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(cmbOrderID.Text) && string.IsNullOrWhiteSpace(txtSKU.Text)) ||
                (!string.IsNullOrWhiteSpace(cmbOrderID.Text) && !string.IsNullOrWhiteSpace(txtSKU.Text)))
            {
                MessageBox.Show("Please provide either Order ID or SKU, but not both.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text) || txtQty.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount and quantity.");
                return;
            }

            string guestName = "";
            if (!string.IsNullOrWhiteSpace(cmbOrderID.Text))
            {
                guestName = GetGuestName(cmbOrderID.Text);
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            int qty = (int)txtQty.Value;


            decimal discount = 0;
            if (!string.IsNullOrWhiteSpace(txtSKU.Text))
            {
                discount = GetDiscountForSKU(txtSKU.Text);
            }

            decimal total = amount * qty;
            decimal finalPrice = total - discount;

            // Add new row to DataGridView
            dataGridView1.Rows.Add(
                PaymentID.Text,
                guestName,
                cmbOrderID.Text,
                txtSKU.Text,
                qty,
                amount,
                total,
                discount,
                finalPrice);

            UpdateTotalAmount();

            ClearInputs();

        }

        private decimal GetDiscountForSKU(string sku)
        {
            decimal discount = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Discount FROM Inventory WHERE SKU = @sku", conn);
                    cmd.Parameters.AddWithValue("@sku", sku);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        discount = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching discount: " + ex.Message);
            }
            return discount;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("No payment items to save");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string orderID = row.Cells["OrderIDColumn"].Value?.ToString()?.Trim();
                            string sku = row.Cells["SKUColumn"].Value?.ToString()?.Trim();

                            if (string.IsNullOrEmpty(orderID) && string.IsNullOrEmpty(sku))
                            {
                                throw new Exception("Each row must have either an Order ID or SKU");
                            }

                            if (!string.IsNullOrEmpty(orderID) && orderID != "WALK-IN" && !OrderExists(orderID))
                            {
                                throw new Exception($"Order ID {orderID} does not exist");
                            }

                            if (string.IsNullOrEmpty(sku))
                            {
                                throw new Exception("SKU is required for each payment item");
                            }

                            SqlCommand cmd = new SqlCommand(
                                @"INSERT INTO Payments (PaymentID, OrderID, SKU, Qty, Amount, Total, GuestName, Discount, FinalPrice)
                          VALUES (@pid, @oid, @sku, @qty, @amt, @total, @guest, @disc, @final)",
                                conn, transaction);

                            cmd.Parameters.AddWithValue("@pid", row.Cells["PaymentIDColumn"].Value?.ToString());
                            cmd.Parameters.AddWithValue("@oid", string.IsNullOrEmpty(orderID) ? (object)DBNull.Value : orderID);
                            cmd.Parameters.AddWithValue("@sku", sku);
                            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["QtyColumn"].Value));
                            cmd.Parameters.AddWithValue("@amt", Convert.ToDecimal(row.Cells["AmountColumn"].Value));
                            cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(row.Cells["TotalColumn"].Value));
                            cmd.Parameters.AddWithValue("@guest", row.Cells["GuestNameColumn"].Value?.ToString() ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@disc", Convert.ToDecimal(row.Cells["DiscountColumn"].Value));
                            cmd.Parameters.AddWithValue("@final", Convert.ToDecimal(row.Cells["FinalPriceColumn"].Value));

                            cmd.ExecuteNonQuery();

                            if (!string.IsNullOrEmpty(orderID) && orderID != "WALK-IN")
                            {
                                SqlCommand updateOrderCmd = new SqlCommand(
                                    "UPDATE Orders SET PaymentStatus = 'Paid' WHERE OrderID = @oid", conn, transaction);
                                updateOrderCmd.Parameters.AddWithValue("@oid", orderID);
                                updateOrderCmd.ExecuteNonQuery();
                            }

                            SqlCommand updateInventoryCmd = new SqlCommand(
                                "UPDATE Inventory SET Quantity = Quantity - @qty WHERE SKU = @sku", conn, transaction);
                            updateInventoryCmd.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["QtyColumn"].Value));
                            updateInventoryCmd.Parameters.AddWithValue("@sku", sku);
                            updateInventoryCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Payment saved successfully");

                        ClearForm();
                        LoadOrderIDs();
                        GeneratePaymentID();
                        dataGridView1.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving payment: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
        private bool OrderExists(string orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE OrderID = @oid", conn))
                {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dataGridView1.Rows.Remove(row);
                }

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private bool IsDuplicateSKU(string sku)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["SKUColumn"].Value.ToString() == sku)
                {
                    return true;
                }
            }
            return false;
        }



        private void ClearForm()
        {
            cmbOrderID.SelectedIndex = -1;
            txtSKU.Clear();
            txtAmount.Clear();
            txtQty.Value = 1;
            txtTotal.Clear();
            txtTotalAmount.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show(); this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Order().Show(); this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new customer().Show(); this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new inventory().Show(); this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            new payment().Show();
        }
        private void UpdateInventoryAfterPurchase(string sku, int purchasedQty)
        {
            string query = "UPDATE Inventory SET Quantity = Quantity - @purchasedQty WHERE SKU = @sku";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@purchasedQty", purchasedQty);
                    cmd.Parameters.AddWithValue("@sku", sku);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sku = txtSKU.Text.Trim();
            if (string.IsNullOrEmpty(sku))
            {
                MessageBox.Show("Please enter SKU to update.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid amount.");
                return;
            }

            int qty = (int)txtQty.Value;
            decimal discount = 0;
            decimal total = amount * qty;
            decimal finalPrice = total - discount;

            bool updated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string rowSKU = row.Cells["SKUColumn"].Value?.ToString();
                if (rowSKU == sku)
                {
                    row.Cells["QtyColumn"].Value = qty;
                    row.Cells["AmountColumn"].Value = amount;
                    row.Cells["TotalColumn"].Value = total;
                    row.Cells["DiscountColumn"].Value = discount;
                    row.Cells["FinalPriceColumn"].Value = finalPrice;
                    updated = true;
                    break;
                }
            }

            if (updated)
                MessageBox.Show("Row updated successfully.");
            else
                MessageBox.Show("No matching SKU found.");
        }
        private void RecalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                decimal finalPrice = 0;
                decimal.TryParse(row.Cells["Final Price"].Value?.ToString(), out finalPrice);
                totalAmount += finalPrice;
            }

            txtTotalAmount.Text = totalAmount.ToString("0.00");
        }
        private bool PaymentRecordExists(string paymentID, string sku)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Payments WHERE PaymentID = @pid AND SKU = @sku";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pid", paymentID);
                    cmd.Parameters.AddWithValue("@sku", sku);
                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        private bool SKUExists(string sku)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Inventory WHERE SKU = @sku";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sku", sku);
                    con.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void PrintBill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("No items to print.");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintBillPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintBillPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            float yPos = 50;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float lineHeight = regularFont.GetHeight();

            // Print header
            string shopName = "Bridal Shop";
            graphics.DrawString(shopName, titleFont, Brushes.Black,
                new RectangleF(leftMargin, yPos, e.MarginBounds.Width, titleFont.GetHeight()),
                new StringFormat { Alignment = StringAlignment.Center });
            yPos += titleFont.GetHeight() + 20;

            // Print payment details
            string paymentID = $"Payment ID: {PaymentID.Text}";
            graphics.DrawString(paymentID, headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 10;

            string orderID = $"Order ID: {(string.IsNullOrEmpty(cmbOrderID.Text) ? "WALK-IN" : cmbOrderID.Text)}";
            graphics.DrawString(orderID, regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            string guestName = $"Customer: {(string.IsNullOrEmpty(cmbOrderID.Text) ? "WALK-IN" : GetGuestName(cmbOrderID.Text))}";
            graphics.DrawString(guestName, regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            string date = $"Date: {DateTime.Now.ToString("g")}";
            graphics.DrawString(date, regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 2;

            // Print table header
            float[] columnWidths = { 150, 50, 70, 70, 80 }; // Adjust as needed
            string[] headers = { "Item Name", "Qty", "Price", "Discount", "Total" };

            for (int i = 0; i < headers.Length; i++)
            {
                graphics.DrawString(headers[i], boldFont, Brushes.Black,
                    leftMargin + (i == 0 ? 0 : columnWidths.Take(i).Sum()), yPos);
            }
            yPos += lineHeight + 5;

            // Draw line under header
            graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            // Print items
            decimal grandTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string sku = row.Cells["SKUColumn"].Value?.ToString() ?? "";
                string itemName = GetItemNameFromSKU(sku);
                string qty = row.Cells["QtyColumn"].Value?.ToString() ?? "";
                string price = row.Cells["AmountColumn"].Value?.ToString() ?? "0";
                string discount = row.Cells["DiscountColumn"].Value?.ToString() ?? "0";
                string total = row.Cells["FinalPriceColumn"].Value?.ToString() ?? "0";

                if (decimal.TryParse(total, out decimal itemTotal))
                {
                    grandTotal += itemTotal;
                }

                // Format numbers to 2 decimal places
                price = decimal.Parse(price).ToString("0.00");
                discount = decimal.Parse(discount).ToString("0.00");
                total = decimal.Parse(total).ToString("0.00");

                graphics.DrawString(itemName, regularFont, Brushes.Black, leftMargin, yPos);
                graphics.DrawString(qty, regularFont, Brushes.Black, leftMargin + columnWidths[0], yPos);
                graphics.DrawString(price, regularFont, Brushes.Black, leftMargin + columnWidths[0] + columnWidths[1], yPos);
                graphics.DrawString(discount, regularFont, Brushes.Black, leftMargin + columnWidths[0] + columnWidths[1] + columnWidths[2], yPos);
                graphics.DrawString(total, regularFont, Brushes.Black, leftMargin + columnWidths[0] + columnWidths[1] + columnWidths[2] + columnWidths[3], yPos);

                yPos += lineHeight;
            }

            yPos += 20;

            // Print total
            graphics.DrawLine(Pens.Black, leftMargin, yPos, rightMargin, yPos);
            yPos += 10;

            string totalText = $"Grand Total: {grandTotal.ToString("0.00")}";
            graphics.DrawString(totalText, boldFont, Brushes.Black,
                rightMargin - graphics.MeasureString(totalText, boldFont).Width, yPos);
            yPos += lineHeight * 2;

            // Print thank you message
            string thankYou = "Thank you for your business!";
            graphics.DrawString(thankYou, regularFont, Brushes.Black,
                new RectangleF(leftMargin, yPos, e.MarginBounds.Width, regularFont.GetHeight()),
                new StringFormat { Alignment = StringAlignment.Center });
        }

        private string GetItemNameFromSKU(string sku)
        {
            string itemName = sku; // Default to SKU if name not found

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Inventory WHERE SKU = @sku", conn);
                    cmd.Parameters.AddWithValue("@sku", sku);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        itemName = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving item name: " + ex.Message);
            }

            return itemName;
        }
    }
    }
