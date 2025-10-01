using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Processing;


namespace Login
{
    public partial class Order : Form
    {
        private readonly string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";

        public Order()
        {
            InitializeComponent();
            LoadOrders();
            ConfigureDataGridView();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Orders ORDER BY OrderID DESC";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load orders: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ConfigureDataGridView()
        {
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["OrderID"].HeaderText = "Order ID";
                dataGridView1.Columns["CustomerName"].HeaderText = "Customer Name";
                dataGridView1.Columns["DressSelection"].HeaderText = "Dress Selection";
                dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
                dataGridView1.Columns["OrderDate"].HeaderText = "Order Date";
                dataGridView1.Columns["DeliveryDate"].HeaderText = "Delivery Date";
                dataGridView1.Columns["OrderStatus"].HeaderText = "Order Status";
                dataGridView1.Columns["PaymentStatus"].HeaderText = "Payment Status";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Total Price";
                dataGridView1.Columns["PaymentMethod"].HeaderText = "Payment Method";
                dataGridView1.Columns["SpecialNotes"].HeaderText = "Special Notes";

                dataGridView1.Columns["OrderDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGridView1.Columns["DeliveryDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Format = "C2";
            }

        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "order_report.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportReport("PDF", sfd.FileName);
                }
            }
        }
        private void ExportReport(string format, string outputPath)
        {
            try
            {
                var report = new OrderReport();

                var reportSource = new InstanceReportSource
                {
                    ReportDocument = report
                };

                var reportProcessor = new ReportProcessor();
                RenderingResult result = reportProcessor.RenderReport(format, reportSource, null);

                if (result == null || result.DocumentBytes == null)
                {
                    MessageBox.Show("Report rendering failed. Check report design, data source, or parameters.");
                    return;
                }

                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length);
                }

                MessageBox.Show($"{format} export successful:\n{Path.GetFullPath(outputPath)}", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report to {format}:\n{ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadOrders();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT * FROM Orders
                        WHERE 
                            CustomerName LIKE @SearchTerm OR 
                            DressID LIKE @SearchTerm OR 
                            OrderStatus LIKE @SearchTerm OR 
                            PaymentStatus LIKE @SearchTerm";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "OrderID")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                string customerName = row.Cells["CustomerName"].Value?.ToString() ?? "";
                string dressSelection = row.Cells["DressSelection"].Value?.ToString() ?? "";
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                DateTime orderDate = Convert.ToDateTime(row.Cells["OrderDate"].Value);
                DateTime deliveryDate = Convert.ToDateTime(row.Cells["DeliveryDate"].Value);
                string orderStatus = row.Cells["OrderStatus"].Value?.ToString() ?? "";
                string paymentStatus = row.Cells["PaymentStatus"].Value?.ToString() ?? "";
                decimal totalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                string paymentMethod = row.Cells["PaymentMethod"].Value?.ToString() ?? "";
                string specialNotes = row.Cells["SpecialNotes"].Value?.ToString() ?? "";

                var addOrderForm = new add_order(
                    orderId, customerName, dressSelection, quantity,
                    orderDate, deliveryDate, orderStatus, paymentStatus,
                    totalPrice, paymentMethod, specialNotes);

                addOrderForm.ShowDialog();

                LoadOrders();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (add_order addForm = new add_order())
            {
                addForm.FormClosed += (s, args) => LoadOrders();
                addForm.ShowDialog();
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Order().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new payment().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new reports().Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Order().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new inventory().Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            new payment().Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            new reports().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
