using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.JobTitles
{
    internal class Manager : Employee
    {
        public void GetNumber()
        {
            Console.WriteLine(PhoneNumber);
        }
        public int PhoneNumber { get; set; }

        public Manager(string firstName, string lastName, int iDNumber, int phoneNumber) : base(firstName, lastName, iDNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
