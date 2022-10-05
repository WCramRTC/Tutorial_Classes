using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Classes
{
    internal class Program
    {
        static List<Course> courses = new List<Course>();
        static List<Teacher> teachers = new List<Teacher>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Preload();

            DisplayCourses();

            Console.ReadKey();

        } // Main

        public static void Preload()
        {
            Course course1 = new Course("Programming 122", "CSI_122_2");
            courses.Add(course1);

            course1 = new Course("Programming 120", "CSI_120_2");
            courses.Add(course1);

            courses.Add(new Course("Programming 252", "CSI_252_1"));

            Teacher teacher1 = new Teacher("William", "Cram");
            teachers.Add(teacher1);

            teachers.Add(new Teacher("Josh", "Emery"));
            teachers.Add(new Teacher("Dimpy", "Gill"));

            Student student1 = new Student("Hannah", "Angel");
            students.Add(student1);
            students.Add(new Student("Kristyn", "Taniguchi"));
            students.Add(new Student("Dylan", "Register"));

            courses[0].Teacher = teachers[0];
            courses[0].Student = students[0];
        } // Preload()

        public static void DisplayCourses()
        {

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"Course Name: {courses[i].Name}");
                Console.WriteLine($"Course Number: {courses[i].CourseNumber}");
                Console.WriteLine($"Course Teacher: {courses[i].Teacher.FirstName} {courses[i].Teacher.LastName}");
                Console.WriteLine($"Course Student: {courses[i].Student.FirstName} {courses[i].Teacher.LastName}");
                Console.WriteLine();
            }
        } // DisplayCourses
        
    } // class

} // namespace
