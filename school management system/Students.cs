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
    public partial class Students : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        public Students()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            // Gather data from form
            string name = name_txt.Text;
            DateTime dob = dateTimePicker1.Value;
            string gender = male_rad.Checked ? "Male" : (female_rad.Checked ? "Female" : "");
            string address = txt_address.Text;
            string phone = txt_phone.Text;

            // Ensure gender is selected
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Create the SQL query for checking duplicates
            string checkQuery = "SELECT COUNT(*) FROM students WHERE name = @name AND dob = @dob AND phone = @phone";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Prepare the command to check if the student exists
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", name);
                    checkCommand.Parameters.AddWithValue("@dob", dob);
                    checkCommand.Parameters.AddWithValue("@phone", phone);

                    // Increase timeout to 60 seconds
                    checkCommand.CommandTimeout = 60; // Default is 30 seconds

                    try
                    {
                        // Open connection to the database
                        connection.Open();

                        // Execute the query and get the count of students with same name, dob, and phone
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // If student already exists, show a message
                            MessageBox.Show("This student is already added.");
                        }
                        else
                        {
                            // Proceed to insert the new student if no duplicates are found
                            string insertQuery = "INSERT INTO students (name, dob, gender, address, phone) VALUES (@name, @dob, @gender, @address, @phone); SELECT SCOPE_IDENTITY();";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@name", name);
                                insertCommand.Parameters.AddWithValue("@dob", dob);
                                insertCommand.Parameters.AddWithValue("@gender", gender);
                                insertCommand.Parameters.AddWithValue("@address", address);
                                insertCommand.Parameters.AddWithValue("@phone", phone);

                                // Execute the insert command
                                int newStudentID = Convert.ToInt32(insertCommand.ExecuteScalar());
                                MessageBox.Show("Student added successfully with ID: " + newStudentID);

                                // Clear the form after successful addition
                                ClearForm();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that occur
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }
        private void ClearForm()
        {
            // Clear all form fields
            name_txt.Clear();
            dateTimePicker1.Value = DateTime.Now;
            male_rad.Checked = false;
            female_rad.Checked = false;
            txt_address.Clear();
            txt_phone.Clear();
        }


        private void lbl_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            update update = new update();
            update.Show();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete delete = new delete();
            delete.Show();

        }

        private void View_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_students view_Students = new view_students();  
            view_Students.Show();   
        }
    }
}
