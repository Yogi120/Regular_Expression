using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    static class Program
    {
        static void Main(string[] args)
        {
            Registration firstname = new Registration();
            firstname.FirstName();

            Registration Lastname = new Registration();
            Lastname.LastName();

            Registration Emailid = new Registration();
            Emailid.Email();

            Registration Mobile_num = new Registration();
            Mobile_num.Mobile();

            Registration mypassword = new Registration();
            mypassword.Password();
        }
    }
}
