using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm.JobTitles
{
    internal class Projectmanager : Manager
    {
        public void GetEmail()
        {
            Console.WriteLine(Email);
        }
        public string Email { get; set; } = string.Empty;

        public Projectmanager(string firstName, string lastName, int iDNumber, int phoneNumber, string Email) : base(firstName, lastName, iDNumber, phoneNumber)
        {
            this.Email = Email;
        }
    }
}
