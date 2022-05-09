using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_performance_Managment;
public class Student
{
    public int student_id;
    public int student_rollNo;
    public string student_name;
    public string student_address;
    public int course_id;


    public Student(int student_id,int student_rollNo, string student_name, string student_address, int course_id)
    {
        this.student_id = student_id;
        this.student_rollNo = student_rollNo;
        this.student_name = student_name;
        this.student_address = student_address;
        this.course_id = course_id;
    }

    public Student()
    {
    }

    public Student Add()
    {


        Console.Write(" \n Enter Student name : >> ");
        var student_name = Console.ReadLine();

        Console.Write("\n Enter Student Roll NO : >> ");
        var student_rollNo = int.Parse(Console.ReadLine());

        Console.Write("\n Enter Student address : >> ");
        var student_address = Console.ReadLine();

        Console.Write("\n Enter Student Course id : >> ");
        var course_id = int.Parse(Console.ReadLine());

        return this;
    }

    public Student Edit()
    {

        Console.Write("\n Enter Student student id : >> ");
         student_id = int.Parse(Console.ReadLine());

        Console.Write(" \n Enter Student name : >> ");
         student_name = Console.ReadLine();

        Console.Write("\n Enter Student Roll NO : >> ");
         student_rollNo = int.Parse(Console.ReadLine());

        Console.Write("\n Enter Student address : >> ");
         student_address = Console.ReadLine();

        Console.Write("\n Enter Student Course id : >> ");
         course_id = int.Parse(Console.ReadLine());

        return this;
    }

    public int Delete()
    {

        Console.Write("\n Enter Student id delete  : >> ");
         student_id = int.Parse(Console.ReadLine());

        return student_id;
    }




}

