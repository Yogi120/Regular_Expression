using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace User_Registration
{
    public class Registration
    {
        public void FirstName()
        {
            // For getting VALID First Name :

            string pattern = "^[A-Z][a-zA-Z]{2,}$";
           
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

        public void LastName()
        {
            // For getting VALID Last Name :

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

        public void Email()
        {
            // For getting VALID Email Id :

            string[] Emails = { "abc.xyz@bl.co.in", "yogesh.pal@bl.co", "yogesh@gmail.com" };

            Regex myEmail = new Regex("[a-z]{3}.[a-z]{3}@[a-z]{2}.[a-z]{2}.[a-z]{2}");

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

        public void Mobile()
        {
            // Getting Valid Phone number

            string[] Phone_num = {"91 1234567890", "41 9919871988", "01 9984 733212" };

            Regex myPhone = new Regex("[1-9]{2}[ ][0-9]{10}");

            foreach (string phone_num in Phone_num)
            {
                if (myPhone.IsMatch(phone_num) == true)
                {
                    Console.WriteLine($"{phone_num} : is VALID phone number");
                }

                else
                {
                    Console.WriteLine($"{phone_num} : is INVALID phone number");
                }
                    
            }
        }
    }
}
