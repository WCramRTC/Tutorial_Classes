using System;
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
        public string _courseNumber;
        public string _teacher;
        public string _student;
        // Constructor

        public Course(string name, string courseNumber)
        {
            _name = name;
            _courseNumber = courseNumber;
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
        }


        // Methods

    } // class

} // namespace
