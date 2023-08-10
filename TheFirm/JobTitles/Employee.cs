using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.JobTitles
{
    internal class Employee
    {
        public void GetName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        public void GetID()
        {
            Console.WriteLine($"{IDNumber}");
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int IDNumber { get; set; }

        public Employee(string firstName, string lastName, int iDNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IDNumber = iDNumber;
        }
    }
}
