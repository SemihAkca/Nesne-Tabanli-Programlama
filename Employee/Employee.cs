using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_odev
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}