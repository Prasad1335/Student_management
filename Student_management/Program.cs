
using Student_management;
using Student_performance_Managment;
using Student_performance_Managment.NewFolder;

test();

void test()
{


    CourseSerivces courseService = new CourseSerivces();
    Course course = new Course();

    //course.DisplayCorseWiseAverageMArks();
    //course.DisplayCourseWiseHighestMarks();
    //course.DisplayCourseWiseTopper();
    MarkServices markServices = new MarkServices();
    Marks mark = new Marks();
    //mark.DisplayMarksByRollNo();
    StudentSeriveces studentSeriveces = new StudentSeriveces();
    Student student = new Student();
    //student.DisplayStudentReport();
    SubjectServices subjectServices = new SubjectServices();
    Subject subject = new Subject();


    Console.WriteLine(" --------  Add Menu  ---------\n");
    Console.WriteLine(" 1. Add Student");
    Console.WriteLine(" 2. Add course");
    Console.WriteLine(" 3. Add subject");
    Console.WriteLine(" 4. Enter marks of student\n");
    Console.WriteLine(" --------- Edit Menu   --------\n");
    Console.WriteLine(" 5. Edit Student data");
    Console.WriteLine(" 6. Edit course");
    Console.WriteLine(" 7. Edit subject\n");
    Console.WriteLine(" --------- Delete Menu --------\n");
    Console.WriteLine(" 8.  Delete Student");
    Console.WriteLine(" 9.  Delete Subject");
    Console.WriteLine(" 10. Delete Course");
    Console.WriteLine(" 11. Delete marks\n");
    Console.WriteLine(" --------- Display Menu --------\n");
    Console.WriteLine(" 12. List all students and total marks");
    Console.WriteLine(" 13. Ask roll number to display subject wise marks for a student");
    Console.WriteLine(" 14. List course wise average marks");
    Console.WriteLine(" 15. List course wise max marks");
    Console.WriteLine(" 16. List course wise topper");
    Console.WriteLine(" 0.  exit \n");
    Console.WriteLine(" ---------------------  output  ---------\n");
    do
    {
        Console.Write(" Enter your Choice >> ");
        var EnterNumber = int.Parse(Console.ReadLine());

        switch (EnterNumber)
        {
            case 1:
                studentSeriveces.Add(student.Add());
                break;
            case 2:
                courseService.Add(course.Add());
                break;
            case 3:
                subjectServices.Add(subject.Add());
                break;
            case 4:
                markServices.AddMarks(mark.AddMarks());
                break;
            case 5:
                studentSeriveces.Edit(student.Edit());
                break;
            case 6:
                courseService.Edit(course.Edit());
                break;
            case 7:
                subjectServices.Edit(subject.Add());
                break;
            case 8:
                studentSeriveces.Delete(student.Delete());
                break;
            case 9:
                subjectServices.Delete(subject.Delete());
                break;
            case 10:
                courseService.Delete(course.Delete());
                break;
            case 11:
                markServices.DeleteMarks(mark.DeleteMarks());
                break;
            default:
                if (EnterNumber == 0)
                    Environment.Exit(0);
                else
                    Console.WriteLine("wrong feild");
                break;
        }
    } while (true);
}
