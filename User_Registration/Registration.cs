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
    }
}
