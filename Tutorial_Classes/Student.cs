using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Classes
{
    internal class Student
    {

        string _firstName;
        string _lastName;
        List<Course> _courses;

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _courses = new List<Course>();
        } // Student

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        } // FirstName

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        } // LastName

        public List<Course> Courses
        {
            get
            {
                return _courses;
            }
        } // Courses

    } // class

} // namespace
