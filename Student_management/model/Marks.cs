using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_performance_Managment.NewFolder;

    internal class Marks
    {
    
        public int mark_id;
        public int student_id;
        public int subject_id;
        public int mark;

    public Marks(  int mark_id,int student_id, int subject_id,int mark)
    {
        this.mark_id = mark_id;
        this.student_id = student_id;
        this.subject_id = subject_id;
        this.mark = mark;  

    }

    public Marks AddMarks()
    {
        Console.Write("\n Enter Student Id : >> ");
         student_id = int.Parse(Console.ReadLine());

        Console.Write(" \n Enter Subject Id : >> ");
         subject_id = int.Parse(Console.ReadLine());

        Console.Write("\n Enter Marks : >> ");
         mark = int.Parse(Console.ReadLine());

        return this;
    }


    public int DeleteMarks()
    {

        Console.Write("\n Enter mark id  : >> ");
        var mark_id = int.Parse(Console.ReadLine());
        return mark_id;
    }
}

