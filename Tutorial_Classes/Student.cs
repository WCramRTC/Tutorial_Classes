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

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
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

    } // class

} // namespace
