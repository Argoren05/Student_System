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
    public partial class GradeForm : Form
    {
        public GradeForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            AddGradeForm addgradeForm = new AddGradeForm();
            addgradeForm.Show(this);
        }

        private void GradeForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspSelectGrade";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridGradeList.DataSource = dataTable;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["studentConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspSelectGrade";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridGradeList.DataSource = dataTable;
        }
    }
}
