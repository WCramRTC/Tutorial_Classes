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
            Course course1 = new Course("Programming 122", "CSI_122_2");

            Console.WriteLine($"Course Name: {course1.Name}");
            Console.WriteLine($"Course Number: {course1._courseNumber}");
            Console.WriteLine($"Course Teacher: {course1._teacher}");
            Console.WriteLine($"Course Student: {course1._student}");



            Console.ReadKey();

        } // Main
        
    } // class

} // namespace
