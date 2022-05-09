using Student_performance_Managment.NewFolder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management
{
    internal class CourseSerivces
    {

        string connectionString = @"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=student_management_performance;Integrated Security=True";



        public void Add(Course c)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand("courses.course_insert", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@course_code", c.course_code));
                Command.Parameters.Add(new SqlParameter("@course_title", c.course_title));
                Command.Parameters.Add(new SqlParameter("@course_description", c.course_description));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : inserted Course Record Successfully...!");
            }

        }
        public void Edit(Course c)
        {



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand("courses.course_update", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@course_id", c.course_id));
                Command.Parameters.Add(new SqlParameter("@course_code", c.course_code));
                Command.Parameters.Add(new SqlParameter("@course_title", c.course_title));
                Command.Parameters.Add(new SqlParameter("@course_description", c.course_description));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Edited Course Record Successfully...!");
            }
        }
        public void Delete(int course_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand("courses.course_delete", connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.Add(new SqlParameter("@course_id", course_id));

                int rowsffected = Command.ExecuteNonQuery();
                Console.WriteLine("\n " + rowsffected + " : Deleted Course Record Successfully...!");
            }

        }
        public void DisplayCorseWiseAverageMArks()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = "courses.course_select";
            SqlCommand Command = new SqlCommand(queryString, connection);

            SqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            reader.Close();
            connection.Close();
        }


        public void DisplayCourseWiseAverageMarks() { }
        public void DisplayCourseWiseHighestMarks() { }
        public void DisplayCourseWiseTopper() { }
    }
}
