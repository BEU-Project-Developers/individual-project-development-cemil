using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        // Event handler for the Cart form load event
        private void Cart_Load(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = "Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=sc;User ID=sa;Password=1";

            // SqlConnection to interact with the database
            SqlConnection con = new SqlConnection(connectionString);

            // Open the database connection
            con.Open();

            try
            {
                // SQL query to calculate the total sum of the cart
                string sumQuery = "SELECT ISNULL(SUM(totalprice), 0) FROM cart";

                // SqlCommand to execute the sumQuery
                SqlCommand sumCmd = new SqlCommand(sumQuery, con);

                // Convert the result to decimal and display it in the total label
                decimal totalSum = Convert.ToDecimal(sumCmd.ExecuteScalar());
                total.Text = totalSum.ToString() + "$";

                // SQL query to select all data from the cart table
                string selectQuery = "SELECT * FROM cart";

                // SqlDataAdapter to fill a DataTable with the results of the selectQuery
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the cart table
                adapter.Fill(dataTable);

                // Set the DataTable as the data source for the DataGridView
                dataGridViewCart.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error loading data from cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection in the finally block to ensure it's always closed
                con.Close();
            }
        }

        // Variables to store the selected row index and cart item id
        int rowIndex;
        int id;

        // Event handler for cell click in the DataGridView
        private void grid_cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row index
            rowIndex = e.RowIndex;

            // Check if a valid row is clicked
            if (rowIndex >= 0)
            {
                // Retrieve the id value from the "id" column of the selected row
                string selected = dataGridViewCart.Rows[rowIndex].Cells["id"].Value.ToString();

                // Convert the id value to an integer and store it in the id variable
                id = Convert.ToInt32(selected);
            }
        }

        // Event handler for the remove button click
        private void button_remove_Click(object sender, EventArgs e)
        {
            // Get the id value of the selected cart item
            int selectedId = id;

            // Database connection string
            string connectionString = "Data Source=LENOVO\\SQLEXPRESS;Initial Catalog=sc;User ID=sa;Password=1";

            // SqlConnection to interact with the database
            SqlConnection con = new SqlConnection(connectionString);

            // Open the database connection
            con.Open();

            try
            {
                // SQL query to delete the selected cart item from the cart table
                string deleteQuery = $"DELETE FROM cart WHERE id = {selectedId}";

                // SqlCommand to execute the deleteQuery
                SqlCommand cmd = new SqlCommand(deleteQuery, con);

                // Execute the SQL query to remove the selected item from the cart
                cmd.ExecuteNonQuery();

                // Recalculate the total sum of the cart
                string sumQuery = "SELECT ISNULL(SUM(totalprice), 0) FROM cart";
                SqlCommand sumCmd = new SqlCommand(sumQuery, con);
                decimal totalSum = Convert.ToDecimal(sumCmd.ExecuteScalar());

                // Update the total label with the new total sum
                total.Text = totalSum.ToString() + "$";

                // Refresh the DataGridView to reflect the updated cart
                string selectQuery = "SELECT * FROM cart";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewCart.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error removing product from cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection in the finally block to ensure it's always closed
                con.Close();
            }
        }

        // Event handler for the order button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the total is 0 or 0.00
            if (total.Text == "0$" || total.Text == "0.00$")
            {
                MessageBox.Show("You don't have products to Order");
            }
            else
            {
                MessageBox.Show("Thank you for your order.");
            }
        }
    }
}
