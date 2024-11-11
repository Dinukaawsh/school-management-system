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
    public partial class delete : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        private int studentId;
        public delete()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students students = new Students();
            students.Show();
        }

        private void btn_id_search_Click(object sender, EventArgs e)
        {
            // Validate that the input is not empty and is a valid integer
            if (string.IsNullOrEmpty(txt_search.Text) || !int.TryParse(txt_search.Text, out studentId))
            {
                MessageBox.Show("Please enter a valid student ID.");
                return;  // Exit the method if input is invalid
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT name, dob, gender, address, phone FROM students WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", studentId);  // Use instance variable studentId

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the fields with student data
                            txt_name.Text = reader["name"].ToString();
                            dateTimePicker.Value = Convert.ToDateTime(reader["dob"]);
                            string gender = reader["gender"].ToString();
                            rad_male.Checked = gender == "Male";
                            rad_female.Checked = gender == "Female";
                            txt_address.Text = reader["address"].ToString();
                            txt_phone.Text = reader["phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No student found with the given ID.");
                        }
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Check if the studentId is set (i.e., student exists)
            if (studentId == 0)
            {
                MessageBox.Show("Please search for a student first.");
                return;
            }

            // Ask for confirmation before deleting the record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Proceed with the deletion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM students WHERE ID = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", studentId);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student deleted successfully!");
                                // Optionally, clear the form after deletion
                                ClearForm();
                            }
                            else
                            {
                                MessageBox.Show("No student found with the given ID.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }
        private void ClearForm()
        {
            // Clear the text boxes and other controls after deletion
            txt_name.Clear();
            dateTimePicker.Value = DateTime.Now;
            rad_male.Checked = false;
            rad_female.Checked = false;
            txt_address.Clear();
            txt_phone.Clear();
            studentId = 0;  // Reset the studentId
        }
    }

}
