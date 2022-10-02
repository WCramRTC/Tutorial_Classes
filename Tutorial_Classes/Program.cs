using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();

            course1._name = "Programming 122";
            course1._courseNumber = "CSI_122_2";
            course1._teacher = "William Cram";
            course1._student = "Hannah Angel";

            Console.WriteLine($"Course Name: {course1._name}");
            Console.WriteLine($"Course Number: {course1._courseNumber}");
            Console.WriteLine($"Course Teacher: {course1._teacher}");
            Console.WriteLine($"Course Student: {course1._student}");



            Console.ReadKey();

        } // Main
        
    } // class

} // namespace
