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
    public partial class inventory : Form
    {
        private readonly string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";
        public inventory()
        {
            InitializeComponent();
            LoadInventory();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            using (add_inventory addForm = new add_inventory())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadInventory();
                }
            }
        }
        private void LoadInventory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT ItemID, SKU, ItemName, Category, Size, Color, Material, Brand, 
                               Quantity, CostPrice, SellingPrice, Discount, FinalPrice, 
                               ReorderLevel, ItemStatus, Location, SupplierName, SupplierContact, DateAdded
                        FROM Inventory";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new inventory().Show();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new inventory().Show();
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

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Login().Show(); // Replace LoginForm with the actual name of your login form
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "inventory_report.pdf";

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
                var report = new InventoryReport();

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
    }
}
