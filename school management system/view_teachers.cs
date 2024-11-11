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
    public partial class view_teachers : Form
    {
        private string connectionString = "Data Source=DINUKA\\MSSQLSERVER01;Initial Catalog=school;Integrated Security=True;Encrypt=False";

        public view_teachers()
        {
            InitializeComponent();
            LoadTeacherData(); // Load data when the form loads
        }

        private void LoadTeacherData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Name, Age, Gender, Phone, Email, Salary, HireDate FROM teachers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable teacherTable = new DataTable();

                    connection.Open();
                    adapter.Fill(teacherTable);
                    dataGridView1.DataSource = teacherTable; // Bind data to the DataGridView
                }
            }
        }

        private void view_teachers_Load(object sender, EventArgs e)
        {
            // Optionally handle form load events here, if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            teachers teachers = new teachers();
            teachers.Show();
        }
    }
}
