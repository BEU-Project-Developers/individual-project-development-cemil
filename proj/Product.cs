using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace proj
{
    public partial class Product : Form
    {
        public Product(string username)
        {
            InitializeComponent();
            // Set the username in the label when the Product form is initialized
            label_user.Text = username;
        }

        // Event handler for the Product form load event
        private void Products_Load(object sender, EventArgs e)
        {
            // Database connection string
            SqlConnection con = new SqlConnection("Data Source=Lenovo\\SQLEXPRESS;Initial Catalog=sc;User ID=sa;Password=1");

            // SQL query to retrieve product information from the database
            SqlCommand cmd = new SqlCommand("SELECT image_path, name, price FROM products", con);

            // SqlDataAdapter to fill a DataTable with the results of the SQL query
            SqlDataAdapter sd = new SqlDataAdapter(cmd);

            // DataTable to store the product information and an additional column for images
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dt.Columns.Add("Image", typeof(Bitmap));

            // Base directory for product images
            string baseDirectory = Path.Combine(Application.StartupPath, "Images");

            // Loop through each row in the DataTable to load images
            foreach (DataRow dr in dt.Rows)
            {
                string imagePath = Path.Combine(baseDirectory, dr["image_path"].ToString());
                if (File.Exists(imagePath))
                {
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    Bitmap bitmap = new Bitmap(ms);
                    dr["Image"] = bitmap;
                }
            }

            // Set the DataTable as the data source for the DataGridView
            grid_products.DataSource = dt;
        }

        // Variable to store the selected row index
        int rowIndex;

        // Event handler for cell click in the DataGridView
        private void grid_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reset count and total labels
            lcount.Text = "0";
            total.Text = "0$";
            rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0)
            {
                // Retrieve product information from the clicked row
                DataGridViewCell imageCell = grid_products.Rows[rowIndex].Cells["Image"];
                string productName = grid_products.Rows[rowIndex].Cells["Name"].Value.ToString();
                string productPrice = grid_products.Rows[rowIndex].Cells["Price"].Value.ToString();

                // Update labels with product information
                label_name.Text = $"Product Name: {productName}";
                label_price.Text = $"Product Price: {productPrice}$";

                // Display the product image
                if (imageCell != null && imageCell.Value != null)
                {
                    Image image = (Image)imageCell.Value;
                    pictureBox1.Image = image;
                }
            }
        }

        // Event handler for the decrease button click
        private void decrease_Click(object sender, EventArgs e)
        {
            // Retrieve product price from the selected row
            string productPrice = grid_products.Rows[rowIndex].Cells["Price"].Value.ToString();

            // Update count and total labels based on decreasing quantity
            if (Convert.ToInt32(lcount.Text) > 0)
            {
                lcount.Text = (Convert.ToInt32(lcount.Text) - 1).ToString();
                total.Text = (Convert.ToInt32(total.Text.Replace("$", "")) - int.Parse(productPrice.Replace(".", ""))).ToString() + "$";
            }
        }

        // Event handler for the increase button click
        private void increase_Click_1(object sender, EventArgs e)
        {
            // Retrieve product price from the selected row
            string productPrice = grid_products.Rows[rowIndex].Cells["Price"].Value.ToString();

            // Update count and total labels based on increasing quantity
            lcount.Text = (Convert.ToInt32(lcount.Text) + 1).ToString();
            total.Text = (Convert.ToInt32(total.Text.Replace("$", "")) + int.Parse(productPrice.Replace(".", ""))).ToString() + "$";
        }

        // Event handler for the add to cart button click
        private void button_add_Click(object sender, EventArgs e)
        {
            // Check if the product amount is greater than 0
            if (lcount.Text == "" || lcount.Text == "0")
            {
                MessageBox.Show("Product amount should be greater than 0");
            }
            else
            {
                // Retrieve product information from the selected row
                string productName = grid_products.Rows[rowIndex].Cells["Name"].Value.ToString();
                decimal productPrice = decimal.Parse(grid_products.Rows[rowIndex].Cells["Price"].Value.ToString());
                int productCount = int.Parse(lcount.Text);
                decimal productTotalPrice = productPrice * productCount;

                // Database connection string
                string connectionString = "Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=sc;User ID=sa;Password=1";

                // SqlConnection to interact with the database
                SqlConnection con = new SqlConnection(connectionString);

                // Open the database connection
                con.Open();

                try
                {
                    // SQL query to insert product information into the cart table
                    string insertQuery = "INSERT INTO cart (name, price, count, totalprice) " +
                                         "VALUES (@ProductName, @ProductPrice, @ProductCount, @ProductTotalPrice)";

                    // SqlCommand to execute the SQL query
                    SqlCommand cmd = new SqlCommand(insertQuery, con);

                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                    cmd.Parameters.AddWithValue("@ProductCount", productCount);
                    cmd.Parameters.AddWithValue("@ProductTotalPrice", productTotalPrice);

                    // Execute the SQL query
                    cmd.ExecuteNonQuery();

                    // Display success message
                    MessageBox.Show("Product added to cart successfully");
                }
                catch (Exception ex)
                {
                    // Display error message if an exception occurs
                    MessageBox.Show($"Error adding product to cart: {ex.Message}\nCheck the Cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the database connection in the finally block to ensure it's always closed
                    con.Close();
                }
            }
        }

        // Event handler for the cart button click
        private void cart_Click(object sender, EventArgs e)
        {
            // Open the Cart form
            Cart cr = new Cart();
            cr.Show();
        }

        // Event handler for the logout button click
        private void logout_Click(object sender, EventArgs e)
        {
            // Hide the current Product form
            this.Hide();

            // Create an instance of the Form1 (login) form
            Form1 fr = new Form1();

            // Show the Form1 (login) form
            fr.Show();
        }
    }
}
