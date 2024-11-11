using System;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide the current form with a fade-out effect and open Students form with fade-in effect
            FadeOut(this);
            Students students = new Students();  // Create an instance of the Students form
            FadeIn(students);
        }

        private void lbl_logout_Click(object sender, EventArgs e)
        {
            // Hide the current form with a fade-out effect and open login_form with fade-in effect
            FadeOut(this);
            login_form login_Form = new login_form();
            FadeIn(login_Form);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide the current form with a fade-out effect and open teachers form with fade-in effect
            FadeOut(this);
            teachers teachers = new teachers();
            FadeIn(teachers);
        }
       

        // Fade-out effect for the current form
        private void FadeOut(Form form)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();  // Explicitly use System.Windows.Forms.Timer
            timer.Interval = 30;  // Set fade-out speed (in milliseconds)
            timer.Tick += (s, e) =>
            {
                if (form.Opacity > 0)
                {
                    form.Opacity -= 0.05;  // Gradually decrease opacity (adjust for speed)
                }
                else
                {
                    timer.Stop();
                    form.Hide();  // Hide the form when opacity reaches 0
                }
            };
            timer.Start();
        }

        // Fade-in effect for the new form
        private void FadeIn(Form form)
        {
            form.Opacity = 0;  // Set opacity to 0 at the start (invisible)
            form.Show();  // Show the form immediately

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();  // Explicitly use System.Windows.Forms.Timer
            timer.Interval = 30;  // Set fade-in speed (in milliseconds)
            timer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                {
                    form.Opacity += 0.05;  // Gradual increase in opacity (adjust for speed)
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
