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
    public partial class update_teacher : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";
        private int teacherId;
        public update_teacher()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            teachers teachers = new teachers();
            teachers.Show();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            int age = Convert.ToInt32(txt_age.Text);
            string gender = rad_male.Checked ? "Male" : (rad_female.Checked ? "Female" : "");
            string phone = txt_phone.Text;
            string email = txt_email.Text;
            decimal salary = Convert.ToDecimal(txt_salary.Text);
            DateTime hireDate = dateTimePicker.Value;

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE teachers SET name = @name, age = @age, gender = @gender, phone = @phone, email = @email, salary = @salary, HireDate = @HireDate WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", teacherId);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@HireDate", hireDate);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Teacher details updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No teacher found with the given ID.");
                    }
                }
            }
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            teacherId = Convert.ToInt32(txt_serech.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT name, age, gender, phone, email, salary, HireDate FROM teachers WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", teacherId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_name.Text = reader["name"].ToString();
                            txt_age.Text = reader["age"].ToString();
                            string gender = reader["gender"].ToString();
                            rad_male.Checked = gender == "Male";
                            rad_female.Checked = gender == "Female";
                            txt_phone.Text = reader["phone"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            txt_salary.Text = reader["salary"].ToString();
                            dateTimePicker.Value = Convert.ToDateTime(reader["HireDate"]);
                        }
                        else
                        {
                            MessageBox.Show("No teacher found with the given ID.");
                        }
                    }
                }
            }
        }

        private void btn_name_Click(object sender, EventArgs e)
        {

            string teacherName = txt_serech.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, age, gender, phone, email, salary, HireDate FROM teachers WHERE name = @name";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", teacherName);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            teacherId = Convert.ToInt32(reader["ID"]);
                            txt_name.Text = teacherName;
                            txt_age.Text = reader["age"].ToString();
                            string gender = reader["gender"].ToString();
                            rad_male.Checked = gender == "Male";
                            rad_female.Checked = gender == "Female";
                            txt_phone.Text = reader["phone"].ToString();
                            txt_email.Text = reader["email"].ToString();
                            txt_salary.Text = reader["salary"].ToString();
                            dateTimePicker.Value = Convert.ToDateTime(reader["HireDate"]);
                        }
                        else
                        {
                            MessageBox.Show("No teacher found with the given name.");
                        }
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
