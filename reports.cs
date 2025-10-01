<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridalDressShopManagement
{
    public partial class reports: Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace Login
{
    public partial class reports : Form
    {
        private string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True;TrustServerCertificate=True";
        public int lastInsertedPaymentId;
        public reports()
        {
            InitializeComponent();
        }
        public bool InsertPayment(string customerName, decimal amount, DateTime paymentDate)
        {
            string query = "INSERT INTO Payments (CustomerName, PaymentAmount, PaymentDate) OUTPUT INSERTED.PaymentID VALUES (@customerName, @amount, @paymentDate)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerName", customerName);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@paymentDate", paymentDate);

                    con.Open();

                    // ExecuteScalar returns the first column of the first row: the new PaymentID
                    lastInsertedPaymentId = (int)cmd.ExecuteScalar();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting payment:\n" + ex.Message);
                return false;
            }
        }
private void reports_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            string query = "SELECT * FROM Payments";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data:\n" + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void NavigateTo(Form targetForm)
        {
            targetForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Login().Show(); // Replace LoginForm with the actual name of your login form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "payment_report.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportReport("PDF", sfd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel files (*.xls)|*.xls";
                sfd.FileName = "payment_report.xls";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportReport("XLS", sfd.FileName);
                }
            }
        }
        private void ExportReport(string format, string outputPath)
        {
            try
            {
                var report = new PaymentReport();

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

        private void button11_Click(object sender, EventArgs e)
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
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
>>>>>>> df4928812b77c8d08c642e5821e346c387662ae5
