using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the login button click
        private void button_login_Click(object sender, EventArgs e)
        {
            // Database connection string
            string connectionString = "Data Source=Lenovo\\SQLEXPRESS;Initial Catalog=sc;User ID=sa;Password=1";

            // Retrieve username and password from input fields
            string username = input_username.Text;
            string password = input_password.Text;

            // Establish a connection to the database using the SqlConnection class
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // SQL query to check the existence of a user with the provided username and password
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";

                // Use a parameterized SqlCommand to prevent SQL injection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query and retrieve the result
                    int result = (int)command.ExecuteScalar();

                    // Check if a user with the given credentials exists
                    if (result > 0)
                    {
                        // Hide the current login form
                        this.Hide();

                        // Create an instance of the Product form, passing the username to it
                        Product productWindow = new Product(input_username.Text);

                        // Show the Product form
                        productWindow.Show();
                    }
                    else
                    {
                        // Display an error message for invalid username or password
                        MessageBox.Show("Invalid username or password");

                        // Clear the input fields
                        input_username.Text = "";
                        input_password.Text = "";
                    }
                }
            }
        }
    }
}
