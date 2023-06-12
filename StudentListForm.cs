using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspSelectStudent";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridStudentList.DataSource = dataTable;
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspSelectStudent";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridStudentList.DataSource = dataTable;
        }

        private void dataStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDelateStudentForm updateDelateStudentForm = new UpdateDelateStudentForm();

            updateDelateStudentForm.textBoxID.Text = dataGridStudentList.CurrentRow.Cells[0].Value.ToString();
            updateDelateStudentForm.textBoxFirstName.Text = dataGridStudentList.CurrentRow.Cells[1].Value.ToString();
            updateDelateStudentForm.textBoxLastName.Text = dataGridStudentList.CurrentRow.Cells[2].Value.ToString();
            updateDelateStudentForm.textBoxIndexNumber.Text = dataGridStudentList.CurrentRow.Cells[3].Value.ToString();
            updateDelateStudentForm.dateTimePicker1.Value = (DateTime)dataGridStudentList.CurrentRow.Cells[4].Value;

            updateDelateStudentForm.Show();

            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show(this);
        }


        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "uspSearchStudent";

                cmd.Parameters.Add("@PARAM", SqlDbType.VarChar).Value = tb_search.Text;

                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridStudentList.DataSource = dataTable;
            
        }

        private void buttonShowGrade_Click(object sender, EventArgs e)
        {
            GradeForm gradeForm = new GradeForm();
            gradeForm.Show(this);
        }
    }
}
