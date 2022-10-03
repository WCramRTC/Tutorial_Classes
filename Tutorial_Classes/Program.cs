﻿using System;
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

        static void Main(string[] args)
        {
            Course course1 = new Course("Programming 122", "CSI_122_2");
            courses.Add(course1);

            course1 = new Course("Programming 120", "CSI_120_2");
            courses.Add(course1);

            courses.Add(new Course("Programming 252", "CSI_252_1"));

            Teacher teacher1 = new Teacher("William", "Cram");
            teachers.Add(teacher1);

            courses[0].Teacher = teachers[0];

            DisplayCourses();

            Console.ReadKey();

        } // Main

        public static void DisplayCourses()
        {

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"Course Name: {courses[i].Name}");
                Console.WriteLine($"Course Number: {courses[i].CourseNumber}");
                Console.WriteLine($"Course Teacher: {courses[i].Teacher.FirstName} {courses[i].Teacher.LastName}");
                Console.WriteLine($"Course Student: {courses[i].Student}");
                Console.WriteLine();
            }
        } // DisplayCourses
        
    } // class

} // namespace
