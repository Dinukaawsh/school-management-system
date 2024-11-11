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
    public partial class delete_teacher : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        public delete_teacher()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            teachers teachers = new teachers();
            teachers.Show();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int teacherId;

            // Validate that the input is a valid integer
            if (!int.TryParse(txt_search.Text, out teacherId))
            {
                MessageBox.Show("Please enter a valid Teacher ID to search.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to find the teacher by ID
                string query = "SELECT Name, Age, Gender, Phone, Email, Salary, HireDate FROM teachers WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", teacherId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the fields with the teacher's information
                            txt_name.Text = reader["Name"].ToString();
                            txt_age.Text = reader["Age"].ToString();
                            string gender = reader["Gender"].ToString();
                            rad_male.Checked = (gender == "Male");
                            rad_female.Checked = (gender == "Female");
                            txt_phone.Text = reader["Phone"].ToString();
                            txt_email.Text = reader["Email"].ToString();
                            txt_salary.Text = reader["Salary"].ToString();
                            dateTimePicker.Value = Convert.ToDateTime(reader["HireDate"]);
                        }
                        else
                        {
                            MessageBox.Show("No teacher found with the given ID.");
                            ClearFields(); // Clear fields if no record is found
                        }
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int teacherId;

            // Validate the input to ensure it's a valid integer
            if (!int.TryParse(txt_search.Text, out teacherId))
            {
                MessageBox.Show("Please enter a valid Teacher ID to delete.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to delete the teacher record by ID
                string query = "DELETE FROM teachers WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", teacherId);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher record deleted successfully!");

                        // Clear all fields after deletion
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No teacher found with the given ID.");
                    }
                }
            }
        }
        private void ClearFields()
        {
            txt_search.Clear();
            txt_name.Clear();
            txt_age.Clear();
            rad_male.Checked = false;
            rad_female.Checked = false;
            txt_phone.Clear();
            txt_email.Clear();
            txt_salary.Clear();
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
