using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        // Variable to track the progress value
        int start = 0;

        // Event handler for the timer tick event
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the progress value
            start += 1;

            // Update the progress bar with the new value
            progress.Value = start;

            // Check if the progress bar value has reached 100
            if (progress.Value == 100)
            {
                // Reset the progress bar to 0
                progress.Value = 0;

                // Stop the timer
                timer1.Stop();

                // Create an instance of the login form
                Form1 login = new Form1();

                // Hide the current splash form
                this.Hide();

                // Show the login form
                login.Show();
            }
        }

        // Event handler for the Splash form load event
        private void Splash_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer1.Start();
        }
    }
}
