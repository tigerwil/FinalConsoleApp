using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Student:Person
    {
        //the : is the inheritance symbol
        //Student is inheriting all the properties from Person

        //Student specific properties
        public DateTime EnrollDate { get; set; }
        public string Major { get; set; }

        //Read Only property
        public string StudentName
        {
            get
            {
                //return FirstName + " " + LastName;
                return LastName + ", " + FirstName;
            }
        }

        //Read Only property to get full name
        //test
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
                
            }
        }


    }
}
