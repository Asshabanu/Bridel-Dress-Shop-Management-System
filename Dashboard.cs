using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Dashboard : Form
    {
        private readonly string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";
        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                lblPendingOrdersCount.Text = GetPendingOrderCount().ToString();
                lblCustomerCount.Text = GetCustomerCount().ToString();
                LoadRecentOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private int GetPendingOrderCount()
        {
            return ExecuteScalarInt("SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Pending'");
        }

        private int GetCustomerCount()
        {
            return ExecuteScalarInt("SELECT COUNT(*) FROM customer");
        }

        private int ExecuteScalarInt(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }
        private void LoadRecentOrders()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT TOP 5 OrderID, CustomerName, OrderDate, TotalPrice FROM Orders ORDER BY OrderDate DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRecentOrders.DataSource = dt;

                FormatRecentOrdersGrid();
            }
        }

        private void FormatRecentOrdersGrid()
        {
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvRecentOrders.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            //dgvRecentOrders.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
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
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new customer().Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Order().Show();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Dashboard().Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
