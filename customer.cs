using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Login
{
    public partial class customer : Form
    {
        private readonly string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";

        public customer()
        {
            InitializeComponent();
            LoadCustomers();
            ConfigureDataGridView();

        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT CustomerID, Name, ContactNumber, EmailAddress, RegistrationDate FROM customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            //Font gridFont = new Font("Bookman Old Style", 12);

            //dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.BackgroundColor = Color.FromArgb(240, 240, 240);
            //dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            //dataGridView1.DefaultCellStyle.Font = gridFont;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            //dataGridView1.RowHeadersVisible = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.MultiSelect = false;
            //dataGridView1.ReadOnly = true;
            //dataGridView1.AllowUserToAddRows = false;

            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bookman Old Style", 12, FontStyle.Bold);
            //dataGridView1.EnableHeadersVisualStyles = false;

            //dataGridView1.GridColor = Color.FromArgb(200, 200, 200);

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["CustomerID"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Customer Name";
                dataGridView1.Columns["ContactNumber"].HeaderText = "Phone";
                dataGridView1.Columns["EmailAddress"].HeaderText = "Email";
                dataGridView1.Columns["RegistrationDate"].HeaderText = "Reg. Date";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (add_customer addForm = new add_customer())
            {
                addForm.FormClosed += (s, args) => LoadCustomers();
                addForm.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = search_text.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadCustomers();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT CustomerID, Name, ContactNumber, EmailAddress, RegistrationDate 
                                     FROM customer 
                                     WHERE Name LIKE @SearchTerm OR 
                                           ContactNumber LIKE @SearchTerm OR 
                                           EmailAddress LIKE @SearchTerm";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
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
            new Login().Show(); // Replace LoginForm with the actual name of your login form
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}