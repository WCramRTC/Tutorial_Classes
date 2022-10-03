﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Classes
{
    internal class Course
    {
        // Fields
        string _name;
        string _courseNumber;
        Teacher _teacher;
        Student _student;
        // Constructor

        public Course(string name, string courseNumber)
        {
            _name = name;
            _courseNumber = courseNumber;
            _teacher = new Teacher("None", "Assigned");
            _student = new Student("None", "Assigned");
        } // Course

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        } // Name

        public string CourseNumber
        {
            get
            {
                return _courseNumber;
            }
            set
            {
                _courseNumber = value;
            }
        }

        public Teacher Teacher
        {
            get
            {
                return _teacher;
            }
            set
            {
                _teacher = value;
            }
        } // Teacher

        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
            }
        }


        // Methods

    } // class

} // namespace
