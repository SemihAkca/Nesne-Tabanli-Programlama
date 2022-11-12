using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdd
{
    public class Student
    {
        public void Person()
        {
            Console.WriteLine("Studdnt class Call");
        }

        private int _id;
        private string _firstName;
        private string _lastName;
        public Student(int id , string FirstName, string LastName) // costructor
        {
            _id = id;   
            _firstName = FirstName;
            _lastName = LastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
     



}
