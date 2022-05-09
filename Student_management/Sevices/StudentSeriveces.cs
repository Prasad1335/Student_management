using Student_performance_Managment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    internal class StudentSeriveces
    {
        string connectionString = @"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=student_management_performance;Integrated Security=True";


        public void Add(Student s)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                //2. command

                SqlCommand Command = new SqlCommand("students.student_insert", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@student_name", s.student_name));
                Command.Parameters.Add(new SqlParameter("@student_rollNo", s.student_rollNo));
                Command.Parameters.Add(new SqlParameter("@student_address", s.student_address));
                Command.Parameters.Add(new SqlParameter("@course_id", s.course_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Add Student Record Successfully...!");
            }
        }


        public void Edit(Student s)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //2. command
                SqlCommand Command = new SqlCommand("students.student_update", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@student_id", s.student_id));
                Command.Parameters.Add(new SqlParameter("@student_name", s.student_name));
                Command.Parameters.Add(new SqlParameter("@student_rollNo", s.student_rollNo));
                Command.Parameters.Add(new SqlParameter("@student_address", s.student_address));
                Command.Parameters.Add(new SqlParameter("@course_id", s.course_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + "  : Edit Student Record Successfully...!");
            }

        }
        public void Delete(int student_id)
        {

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //2. command
                SqlCommand Command = new SqlCommand("students.student_delete", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@student_id", student_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Delete Student Record Successfully...!");
            }


        }
        public void DisplayStudentReport()
        {

        }
    }
}
