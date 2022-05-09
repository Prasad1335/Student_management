using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_performance_Managment.NewFolder;

public class Subject
{
    public int subject_id;
    public string subject_code;
    public string subject_title;
    public string subject_description;
    public int course_id;


    public Subject(int subject_id,string subject_code, string subject_title, string subject_description, int course_id)
    {
        this.subject_id = subject_id;
        this.subject_code = subject_code;
        this.subject_title = subject_title;
        this.subject_description = subject_description;
        this.course_id = course_id;

    }

    public Subject()
    {
    }

    public Subject Add()
    {


        Console.Write("\n Enter Subject code NO : >> ");
         subject_code = Console.ReadLine();

        Console.Write(" \n Enter Subject title : >> ");
         subject_title = Console.ReadLine();

        Console.Write("\n Enter Subject description : >> ");
         subject_description = Console.ReadLine();

        Console.Write("\n Enter Student Course id : >> ");
         course_id = int.Parse(Console.ReadLine());
        return this;
    }

    public Subject Edit()
    {

        Console.Write("\n Enter  subject id : >> ");
         subject_id = int.Parse(Console.ReadLine());

        Console.Write("\n Enter Subject code NO : >> ");
         subject_code = Console.ReadLine();

        Console.Write(" \n Enter Subject title : >> ");
         subject_title = Console.ReadLine();

        Console.Write("\n Enter Subject description : >> ");
         subject_description = Console.ReadLine();

        Console.Write("\n Enter Student Course id : >> ");
         course_id = int.Parse(Console.ReadLine());

        return this;
    }

    public int Delete()
    {

        Console.Write("\n Enter subject id delete data : >> ");
         subject_id = int.Parse(Console.ReadLine());

        return subject_id;
    }

}

