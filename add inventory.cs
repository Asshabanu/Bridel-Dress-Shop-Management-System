using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Login
{
    public partial class add_inventory : Form
    {
        string connectionString = "Server=DESKTOP-JBANP1R;Database=bridal_shop;Integrated Security=True; TrustServerCertificate=True";
        private int? editingItemId = null;

        public add_inventory()
        {
            InitializeComponent();
            InitializeForm();
            txtSKU.Text = GenerateSKU();
            InitializeScrollPanel();

        }

        private Panel scrollPanel;

        private void InitializeScrollPanel()
        {
            scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            var controlsToMove = this.Controls.Cast<Control>().ToList();
            this.Controls.Clear();
            foreach (Control ctrl in controlsToMove)
            {
                scrollPanel.Controls.Add(ctrl);
            }

            this.Controls.Add(scrollPanel);
        }

        public add_inventory(int itemId)
        {
            InitializeComponent();
            InitializeForm();
            editingItemId = itemId;
            LoadItem(itemId);
        }

        private void InitializeForm()
        {
            cmbCategory.Items.AddRange(new string[] { "Wedding Dress", "Veil", "Shoes", "Accessories", "Jewelry" });
            cmbSize.Items.AddRange(new string[] { "XS", "S", "M", "L", "XL", "XXL" });
            cmbBrand.Items.AddRange(new string[] { "Vera Wang", "Zuhair Murad", "Pronovias", "Mori Lee", "Maggie Sottero", "Allure Bridals", "Custom" });
            cmbItemStatus.Items.AddRange(new string[] { "Available", "Out of Stock", "Discontinued" });
            dtpDateAdded.Value = DateTime.Today;

            txtDiscount.TextChanged += txtDiscount_TextChanged;
        }
        private void LoadItem(int itemId)
        {
            string query = "SELECT * FROM Inventory WHERE ItemID = @ItemID";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", itemId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtSKU.Text = reader["SKU"].ToString();
                                txtSKU.ReadOnly = true;
                                txtItemName.Text = reader["ItemName"].ToString();
                                cmbCategory.Text = reader["Category"].ToString();
                                cmbSize.Text = reader["Size"].ToString();
                                txtColor.Text = reader["Color"].ToString();
                                txtMaterial.Text = reader["Material"].ToString();
                                cmbBrand.Text = reader["Brand"].ToString();
                                txtQuantity.Text = reader["Quantity"].ToString();
                                txtCostPrice.Text = reader["CostPrice"].ToString();
                                txtSellingPrice.Text = reader["SellingPrice"].ToString();
                                txtDiscount.Text = reader["Discount"].ToString();
                                txtReorderLevel.Text = reader["ReorderLevel"].ToString();
                                cmbItemStatus.Text = reader["ItemStatus"].ToString();
                                txtLocation.Text = reader["Location"].ToString();
                                txtSupplierName.Text = reader["SupplierName"].ToString();
                                txtSupplier.Text = reader["SupplierContact"].ToString();
                                dtpDateAdded.Value = Convert.ToDateTime(reader["DateAdded"]);

                                if (reader["Photo"] != DBNull.Value)
                                    pictureBoxItem.Image = ByteArrayToImage((byte[])reader["Photo"]);
                                else
                                    pictureBoxItem.Image = null;
                            }
                            else
                            {
                                MessageBox.Show("Item not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item:\n" + ex.Message);
            }
        }

        private string GenerateSKU()
        {
            string sku;
            do
            {
                sku = "SKU" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            } while (SKUExists(sku));
            return sku;
        }

        private bool SKUExists(string sku)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE SKU = @SKU", con);
                cmd.Parameters.AddWithValue("@SKU", sku);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private byte[] ImageToByteArray(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void sellerprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void costprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppliername_TextChanged(object sender, EventArgs e)
        {

        }

        private void recorderlevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
            cmbBrand.SelectedIndex = -1;
            cmbItemStatus.SelectedIndex = -1;
            txtColor.Clear();
            txtMaterial.Clear();
            txtQuantity.Clear();
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtDiscount.Clear();
            txtReorderLevel.Text = "0";
            txtLocation.Clear();
            txtSupplierName.Clear();
            txtSupplier.Clear();
            pictureBoxItem.Image = null;
            dtpDateAdded.Value = DateTime.Today;
            txtSKU.Text = GenerateSKU();
            txtSKU.ReadOnly = false;
            editingItemId = null;
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(out string error))
            {
                MessageBox.Show(error);
                return;
            }

            int quantity = int.Parse(txtQuantity.Text);
            decimal costPrice = decimal.Parse(txtCostPrice.Text);
            decimal sellingPrice = decimal.Parse(txtSellingPrice.Text);
            decimal discount = 0;
            int reorderLevel = int.Parse(txtReorderLevel.Text);
            if (!decimal.TryParse(txtDiscount.Text, out discount)) discount = 0;
            byte[] imageBytes = ImageToByteArray(pictureBoxItem.Image);

            if (imageBytes != null && imageBytes.Length > 2_000_000)
            {
                MessageBox.Show("Image file too large. Please use an image under 2MB.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    if (editingItemId.HasValue)
                    {
                        string updateQuery = @"UPDATE Inventory SET 
                            SKU=@SKU, ItemName=@ItemName, Category=@Category, Size=@Size, Color=@Color, 
                            Material=@Material, Brand=@Brand, Quantity=@Quantity, CostPrice=@CostPrice, 
                            SellingPrice=@SellingPrice, Discount=@Discount, ReorderLevel=@ReorderLevel, 
                            ItemStatus=@ItemStatus, Location=@Location, SupplierName=@SupplierName, 
                            SupplierContact=@SupplierContact, DateAdded=@DateAdded, Photo=@Photo
                            WHERE ItemID = @ItemID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@SKU", txtSKU.Text);
                            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@Size", cmbSize.Text);
                            cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                            cmd.Parameters.AddWithValue("@Material", txtMaterial.Text);
                            cmd.Parameters.AddWithValue("@Brand", cmbBrand.Text);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                            cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            cmd.Parameters.AddWithValue("@Discount", discount);
                            cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                            cmd.Parameters.AddWithValue("@ItemStatus", cmbItemStatus.Text);
                            cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);
                            cmd.Parameters.AddWithValue("@SupplierContact", txtSupplier.Text);
                            cmd.Parameters.AddWithValue("@DateAdded", dtpDateAdded.Value);
                            cmd.Parameters.AddWithValue("@Photo", (object)imageBytes ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@ItemID", editingItemId.Value);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item updated successfully.");
                            this.Close();
                        }
                    }
                    else
                    {
                        SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Inventory WHERE SKU = @SKU", con);
                        checkCmd.Parameters.AddWithValue("@SKU", txtSKU.Text);
                        int exists = (int)checkCmd.ExecuteScalar();
                        if (exists > 0)
                        {
                            MessageBox.Show("Duplicate SKU detected. Please try again.");
                            return;
                        }

                        string insertQuery = @"INSERT INTO Inventory 
                        (SKU, ItemName, Category, Size, Color, Material, Brand, Quantity, CostPrice, 
                         SellingPrice, Discount, ReorderLevel, ItemStatus, Location, SupplierName, 
                         SupplierContact, DateAdded, Photo)
                         VALUES
                        (@SKU, @ItemName, @Category, @Size, @Color, @Material, @Brand, @Quantity, 
                         @CostPrice, @SellingPrice, @Discount, @ReorderLevel, @ItemStatus, 
                         @Location, @SupplierName, @SupplierContact, @DateAdded, @Photo)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@SKU", txtSKU.Text);
                            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                            cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@Size", cmbSize.Text);
                            cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                            cmd.Parameters.AddWithValue("@Material", txtMaterial.Text);
                            cmd.Parameters.AddWithValue("@Brand", cmbBrand.Text);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                            cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                            cmd.Parameters.AddWithValue("@Discount", discount);
                            cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                            cmd.Parameters.AddWithValue("@ItemStatus", cmbItemStatus.Text);
                            cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);
                            cmd.Parameters.AddWithValue("@SupplierContact", txtSupplier.Text);
                            cmd.Parameters.AddWithValue("@DateAdded", dtpDateAdded.Value);
                            cmd.Parameters.AddWithValue("@Photo", (object)imageBytes ?? DBNull.Value);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item saved successfully.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save item:\n" + ex.Message);
            }
        }
        private bool ValidateForm(out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(txtItemName.Text))
                errorMessage = "Item Name is required.";
            else if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
                errorMessage = "Invalid Quantity.";
            else if (!decimal.TryParse(txtCostPrice.Text, out decimal costPrice) ||
                     !decimal.TryParse(txtSellingPrice.Text, out decimal sellingPrice))
                errorMessage = "Invalid Cost or Selling Price.";
            else if (!int.TryParse(txtReorderLevel.Text, out int reorderLevel) || reorderLevel < 0)
                errorMessage = "Invalid Reorder Level.";
            else if (string.IsNullOrWhiteSpace(cmbCategory.Text) ||
                     string.IsNullOrWhiteSpace(cmbSize.Text) ||
                     string.IsNullOrWhiteSpace(cmbBrand.Text) ||
                     string.IsNullOrWhiteSpace(cmbItemStatus.Text))
                errorMessage = "Please select Category, Size, Brand, and Item Status.";

            return string.IsNullOrEmpty(errorMessage);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|.jpg;.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxItem.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCostPrice.Text, out decimal cost) &&
               decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                decimal discountedPrice = cost - (cost * (discount / 100));
                txtSellingPrice.Text = discountedPrice.ToString("0.00");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtReorderLevel_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
