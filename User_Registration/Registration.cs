using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class Registration
    {
        // For getting VALID First Name :
        public void FirstName()
        {
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            // "^[A-Z][a-zA-Z]{2,}$"
            string[] Names = { "Yogesh", "Amit", "rohan" };

            Regex myName = new Regex(pattern);

            foreach (string Name in Names)
            {
                if (myName.IsMatch(Name) == true)
                {
                    Console.WriteLine($"{Name} : is a VALID Name");
                }

                else 
                {
                    Console.WriteLine($"{Name} : is a INVALID!! Name");
                }
            }
        }

        // For getting VALID Last Name :
        public void LastName()
        {
            string[] Last_name = { "Pal", "thorat", "Kapoor" };

            Regex mylast = new Regex("^[A-Z][a-zA-Z]{2,}$");

            foreach (string last_name in Last_name)
            {
                if (mylast.IsMatch(last_name) == true)
                {
                    Console.WriteLine($"{last_name} is VALID last name");
                }

                else
                {
                    Console.WriteLine($"{last_name} is INVALID last name");
                }
            }
             
         }

        // For getting VALID Email Id :
        public void Email()
        {
            string[] Emails = { "abc.xyz@bl.co.in", "yogesh.pal@bl.co", "yogesh@gmail.com" };

            Regex myEmail = new Regex("[a-z]{3}.[a-z]{3}@[a-z]{2}.[a-z]{2}.[a-z]{2}");
            // @"^abc\.bl\.co(@xyz\.in)?@.*$"
            // Regex emailRegex = new Regex(@"^abc\.bl\.co(?:@xyz\.in)?@.*$");


            foreach (string email in Emails)
            {
                if (myEmail.IsMatch(email) == true)
                {
                    Console.WriteLine($"{email} : is VALID email");
                }

                else
                {
                    Console.WriteLine($"{email} : is INVALID email");
                }
            }

        }
    }
}
