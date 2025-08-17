using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;


namespace Login
{
    public partial class add_customer : Form
    {
        string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";

        public add_customer()
        {
            InitializeComponent();
            LoadForm();
        }


        private void LoadForm()
        {
            try
            {
                cus_id_text.Text = GetNextCustomerID().ToString();
                Date.Value = DateTime.Now;
                Date.Enabled = false;
                name_text.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}",
                              "Initialization Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private int GetNextCustomerID()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(CustomerID), 0) + 1 FROM customer";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name_text.Text))
            {
                name_text.BackColor = Color.MistyRose;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(number_text.Text) ||
                !Regex.IsMatch(number_text.Text, @"^[0-9]{10,15}$"))
            {
                number_text.BackColor = Color.MistyRose;
                isValid = false;
            }

            if (!string.IsNullOrWhiteSpace(email_text.Text) &&
                !Regex.IsMatch(email_text.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                email_text.BackColor = Color.MistyRose;
                isValid = false;
            }

         
            return isValid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_customer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
          if (!ValidateInputs()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO customer 
                                   (Name, ContactNumber, EmailAddress, Address, RegistrationDate) 
                                    VALUES 
                                    (@Name, @ContactNumber, @EmailAddress, @Address, @RegistrationDate);
                                    SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name_text.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContactNumber", number_text.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmailAddress", string.IsNullOrWhiteSpace(email_text.Text) ?
                            DBNull.Value : (object)email_text.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(address_text.Text) ?
                            DBNull.Value : (object)address_text.Text.Trim());
                 
                        cmd.Parameters.AddWithValue("@RegistrationDate", Date.Value);

                        conn.Open();
                        int newCustomerId = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show($"Customer #{newCustomerId} saved successfully!",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        ClearForm();
                        cus_id_text.Text = GetNextCustomerID().ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error #{ex.Number}: {ex.Message}",
                              "Database Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            name_text.Text = "";
            number_text.Text = "";
            email_text.Text = "";
            address_text.Text = "";
            Date.Value = DateTime.Now;

            name_text.BackColor = Color.White;
            number_text.BackColor = Color.White;
            email_text.BackColor = Color.White;
          
            name_text.Focus();
        }




        private void delete_Click(object sender, EventArgs e)
        {
            ClearForm();
            cus_id_text.Text = GetNextCustomerID().ToString();
        }

        private void number_text_TextChanged(object sender, EventArgs e)
        {
            number_text.BackColor =
        (!Regex.IsMatch(number_text.Text, @"^[0-9]{10,15}$")) ? Color.MistyRose : Color.White;

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void address_text_TextChanged(object sender, EventArgs e)
        {
            address_text.BackColor = string.IsNullOrWhiteSpace(address_text.Text) ? Color.MistyRose : Color.White;
        }

        private void email_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_text.Text))
            {
                email_text.BackColor = Color.White;
            }
            else
            {
                email_text.BackColor =
                    Regex.IsMatch(email_text.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") ? Color.White : Color.MistyRose;
            }

        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            name_text.BackColor = string.IsNullOrWhiteSpace(name_text.Text) ? Color.MistyRose : Color.White;
        }

        private void cus_id_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

