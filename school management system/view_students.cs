using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class view_students : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";

        public view_students()
        {
            InitializeComponent();
        }

        // Go back to the Students form when label2 is clicked
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current view_students form
            Students students = new Students(); // Create an instance of the Students form
            students.Show(); // Show the Students form
        }

        // Function to load students from the database
        private void LoadStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM students ORDER BY id ASC"; // Query to fetch all students
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);  // Fill the DataTable with student records

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);  // Show the error message in case of an exception
                    }
                }
            }
        }

        // Load students when the form loads
        private void view_students_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
