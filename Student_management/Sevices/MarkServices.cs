using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    internal class MarkServices
    {
        string connectionString = @"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=student_management_performance;Integrated Security=True";


        public void AddMarks(int rollno,int subject_title,int mark)
        {
           
          


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
           

                SqlCommand Command = new SqlCommand("marks.mark_insert", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
             
                Command.Parameters.Add(new SqlParameter("@student_id", rollno));
                Command.Parameters.Add(new SqlParameter("@subject_id", subject_title));
                Command.Parameters.Add(new SqlParameter("@mark", mark));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + "  :  Inserted Mark Record Successfully...!");
            }
        }

        public void DeleteMarks(int rollno)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               
                SqlCommand Command = new SqlCommand("marks.mark_delete", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@mark_id", rollno));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + "  :  Deleted Mark Record Successfully...!");
            }
        }

        public void DisplayMarksByRollNo()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
           
            string queryString = "marks.mark_select";
            SqlCommand Command = new SqlCommand(queryString, connection);
         
            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " " + reader[3].ToString());
            }
            reader.Close();
            connection.Close();
        }

    }
}
