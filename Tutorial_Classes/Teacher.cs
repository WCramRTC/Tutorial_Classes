using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Classes
{
    internal class Teacher
    {

        // fields
        string _firstName;
        string _lastName;

        // constructor
        public Teacher(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        } // Teacher

        // properties
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

        // method

    } // class

} // namespace
