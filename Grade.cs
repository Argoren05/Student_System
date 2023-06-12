using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    internal class Grade
    {

        string connectionString = ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString;

        public bool insertGrade(int StudentId, string StudentName, string StudentLastName, string Subject, string Grade)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspInsertGrade";

            cmd.Parameters.Add("@studentId", SqlDbType.Int).Value = StudentId;
            cmd.Parameters.Add("@studentName", SqlDbType.VarChar).Value = StudentName;
            cmd.Parameters.Add("@studentLastName", SqlDbType.VarChar).Value = StudentLastName;
            cmd.Parameters.Add("@subject", SqlDbType.VarChar).Value = Subject;
            cmd.Parameters.Add("@grade", SqlDbType.VarChar).Value = Grade;

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
