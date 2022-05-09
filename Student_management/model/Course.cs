using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Student_performance_Managment.NewFolder;

public class Course
{
    public int course_id;
    public string course_title;
    public string course_code;
    public string course_description;


    public Course()
    {
    }

    public Course(int course_id, string course_code, string course_title, string course_description)
    {
        this.course_id = course_id;
        this.course_title = course_title;
        this.course_code = course_code;
        this.course_description = course_description;

    }

    public Course Add()
    {

        Console.Write("\n Enter Course code NO : >> ");
        course_code = Console.ReadLine();

        Console.Write(" \n Enter Course title : >> ");
        course_title = Console.ReadLine();

        Console.Write("\n Enter Course description : >> ");
        course_description = Console.ReadLine();

        return this;
    }

    public Course Edit()
    {

        Console.Write("\n Enter Course id change data : >> ");
        course_id = int.Parse(Console.ReadLine());

        Console.Write("\n Enter Course code NO : >> ");
        course_code = Console.ReadLine();

        Console.Write(" \n Enter Course title : >> ");
        course_title = Console.ReadLine();

        Console.Write("\n Enter Course description : >> ");
        course_description = Console.ReadLine();

        return this;
    }

    public int Delete()
    {
        Console.Write("\n Enter Course id delete data : >> ");
        course_id = int.Parse(Console.ReadLine());

        return course_id;
    }


}


