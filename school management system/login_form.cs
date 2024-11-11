using System;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Define the correct credentials
            string correctUsername = "admin";
            string correctPassword = "admin123";

            // Retrieve user input
            string enteredUsername = textBox1.Text;  // Assuming usernameTextBox is the textbox for username
            string enteredPassword = textBox2.Text;  // Assuming passwordTextBox is the textbox for password

            // Check credentials
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                // Login successful, open the dashboard with fade-in effect
                dashboard dashboard = new dashboard(); // Assuming DashboardForm is the form for the dashboard page
                FadeOut(this);  // Fade out the current login form
                FadeIn(dashboard);  // Fade in the dashboard form
            }
            else
            {
                // Login failed, show error message
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fade-out effect for the login form
        private void FadeOut(Form form)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();  // Explicitly use System.Windows.Forms.Timer
            timer.Interval = 30; // Set fade-out speed (in milliseconds)
            timer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.05; // Gradually decrease opacity (adjust for speed)
                }
                else
                {
                    timer.Stop();
                    form.Hide();  // Hide the form when opacity reaches 0
                }
            };
            timer.Start();
        }

        // Fade-in effect for the dashboard form
        private void FadeIn(Form form)
        {
            form.Opacity = 0;  // Set opacity to 0 at the start (invisible)
            form.Show();  // Show the form immediately

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();  // Explicitly use System.Windows.Forms.Timer
            timer.Interval = 30; // Set fade-in speed (in milliseconds)
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.05; // Gradual increase in opacity (adjust for speed)
                }
                else
                {
                    timer.Stop();  // Stop the timer once opacity is fully 1 (visible)
                }
            };
            timer.Start();  // Start the timer
        }
    }
}
