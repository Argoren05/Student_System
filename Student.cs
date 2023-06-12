using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_System
{
    internal class Student
    {
        string connectionString = ConfigurationManager.ConnectionStrings["StudentConnectionString"].ConnectionString;

        public bool insertStudent(string FirstName, string LastName, string IndexNumber, DateTime BirthDate)
        {
            SqlConnection conn = new SqlConnection(connectionString);
           
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspInsertStudent";

            cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = FirstName;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = LastName;
            cmd.Parameters.Add("@index_number", SqlDbType.VarChar).Value = IndexNumber;
            cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = BirthDate;

            conn.Open();

            if(cmd.ExecuteNonQuery() == 1)
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

        public bool updateStudent(int Id, string FirstName, string LastName, string IndexNumber, DateTime BirthDate) 
        {
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspUpdateStudent";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = FirstName;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = LastName;
            cmd.Parameters.Add("@index_number", SqlDbType.VarChar).Value = IndexNumber;
            cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = BirthDate;

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

        public bool deleteStudent(int Id) 
        {
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspDeleteStudent";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;

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
