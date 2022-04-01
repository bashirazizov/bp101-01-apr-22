using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Person(string Name, string Surname, string Email, int Age)
        {
            if (Name.Length>100)
            {
                throw new UserNameInvalidException("User name is invalid. Because it is too long.");
            }
            if (Surname.Length > 100)
            {
                throw new UserSurnameInvalidException("User surname is invalid. Because it is too long.");
            }
            new MailAddress(Email);

            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Age = Age;
        }
    }
}
