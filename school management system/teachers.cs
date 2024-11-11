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

namespace school_management_system
{
    public partial class teachers : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        public teachers()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Gather data from form fields
            string name = txt_name.Text;
            int age = Convert.ToInt32(txt_age.Text); // Assuming there's a textbox for age
            string gender = rad_male.Checked ? "Male" : (rad_female.Checked ? "Female" : ""); // Assuming radio buttons for gender
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            decimal salary = Convert.ToDecimal(txt_salary.Text); // Assuming there's a textbox for salary
            DateTime hireDate = dateTimePicker.Value; // Assuming there's a DateTimePicker for hire date

            // Ensure gender is selected
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Create the SQL connection string (make sure it's correct)
            string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to insert a new teacher
                string query = "INSERT INTO teachers (Name, Age, Gender, Phone, Email, Salary, HireDate) " +
                               "VALUES (@name, @age, @gender, @phone, @email, @salary, @hireDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@hireDate", hireDate);

                    try
                    {
                        // Open connection and execute query
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the insertion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher added successfully!");
                            ClearForm(); // Optionally clear the form after adding the teacher
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the teacher.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void ClearForm()
        {
            // Clear all form fields after successful insertion
            txt_name.Clear();
            txt_age.Clear();
            rad_male.Checked = false;
            rad_male.Checked = false;
            txt_phone.Clear();
            txt_email.Clear();
            txt_salary.Clear();
            dateTimePicker.Value = DateTime.Now;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();
            update_teacher update_Teacher = new update_teacher();
            update_Teacher.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete_teacher delete_Teacher = new delete_teacher();
            delete_Teacher.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_teachers view_Teachers = new view_teachers();
            view_Teachers.Show();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
