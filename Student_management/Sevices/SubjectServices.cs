using Student_performance_Managment.NewFolder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    internal class SubjectServices
    {
        string connectionString = @"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=student_management_performance;Integrated Security=True";

        public void Add(Subject s)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand("courses.subject_insert", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@subject_code", s.subject_code));
                Command.Parameters.Add(new SqlParameter("@subject_title", s.subject_title));
                Command.Parameters.Add(new SqlParameter("@subject_description", s.subject_description));
                Command.Parameters.Add(new SqlParameter("@course_id",s.course_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Inserted Subject Record  Successfully....!");
            }

        }

        public void Edit(Subject s)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand Command = new SqlCommand("courses.subject_update", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@subject_id", s.subject_id));
                Command.Parameters.Add(new SqlParameter("@subject_code", s.subject_code));
                Command.Parameters.Add(new SqlParameter("@subject_title", s.subject_title));
                Command.Parameters.Add(new SqlParameter("@subject_description",s. subject_description));
                Command.Parameters.Add(new SqlParameter("@course_id", s.course_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n" + rowsffected + " : Updated Subject Record  Successfully....!");
            }


        }

        public void Delete(int subject_id)
        {

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //2. command
                SqlCommand Command = new SqlCommand("courses.subject_delete", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@subject_id", subject_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Delete subject Record Successfully...!");
            }

        }



    }
}
