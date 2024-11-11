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
    public partial class update : Form
    {

        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        private int studentId;
        public update()
        {
            InitializeComponent();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            studentId = Convert.ToInt32(txt_search.Text);  // Use the instance variable instead of declaring a local one

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
                            dateTimePickerdob.Value = Convert.ToDateTime(reader["dob"]);
                            string gender = reader["gender"].ToString();
                            Rad_male.Checked = gender == "Male";
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

        private void btn_name_Click(object sender, EventArgs e)
        {
            string studentName = txt_search.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, dob, gender, address, phone FROM students WHERE name = @name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", studentName);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the fields with student data
                            command.Parameters.AddWithValue("@id", studentId);
                            txt_name.Text = studentName;  // Assuming the name is the search result
                            dateTimePickerdob.Value = Convert.ToDateTime(reader["dob"]);
                            string gender = reader["gender"].ToString();
                            Rad_male.Checked = gender == "Male";
                            rad_female.Checked = gender == "Female";
                            txt_address.Text = reader["address"].ToString();
                            txt_phone.Text = reader["phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No student found with the given name.");
                        }
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Students students = new Students();
            students.Show();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            DateTime dob = dateTimePickerdob.Value;
            string gender = Rad_male.Checked ? "Male" : (rad_female.Checked ? "Female" : "");
            string address = txt_address.Text;
            string phone = txt_phone.Text;

            // Ensure gender is selected
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL Update query, ID should remain unchanged
                string query = "UPDATE students SET name = @name, dob = @dob, gender = @gender, address = @address, phone = @phone WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", studentId);  // Use the captured student ID
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@phone", phone);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();  // Executes the update query

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully!");
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
}
    

