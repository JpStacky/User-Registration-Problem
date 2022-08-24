using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class ProgramUC12
    {
        public static void Main()
        {
            CustomExceptionUC12 customExceptionUC12 = new CustomExceptionUC12();
            try
            {
                Console.Write("Enter First Name = ");
                string firt_Name = Console.ReadLine();
                customExceptionUC12.ValidateFirstName(firt_Name);

                Console.Write("Enter Last Name = ");
                string last_Name = Console.ReadLine();
                customExceptionUC12.ValidateLastName(last_Name);

                Console.Write("Enter Email = ");
                string email = Console.ReadLine();
                customExceptionUC12.ValidateEMail(email);

                Console.Write("Enter Mobile Number = ");
                string mobile_Number = Console.ReadLine();
                customExceptionUC12.ValidateMobileNumber(mobile_Number);

                Console.Write("Enter Password = ");
                string password = Console.ReadLine();
                customExceptionUC12.ValidateFirstName(password);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
