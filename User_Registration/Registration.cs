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
    }
}
