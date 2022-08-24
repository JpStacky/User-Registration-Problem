using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class ProgramUC13
    {
        public static void Main()
        {
            LambdaValidationUC13 lambdaValidationUC13 = new LambdaValidationUC13();
            string result;

            Console.Write("Enter First Name = ");
            string firt_Name = Console.ReadLine();
            result = lambdaValidationUC13.lambda_Expression_To_Check_First_Name(firt_Name);
            Console.WriteLine(result);

            Console.Write("Enter Last Name = ");
            string last_Name = Console.ReadLine();
            result =  lambdaValidationUC13.lambda_Expression_To_Check_Last_Name(last_Name);
            Console.WriteLine(result);

            Console.Write("Enter Email = ");
            string email = Console.ReadLine();
            result = lambdaValidationUC13.lambda_Expression_To_Validate_Email(email);
            Console.WriteLine(result);

            Console.Write("Enter Mobile Number = ");
            string mobile_Number = Console.ReadLine();
            result = lambdaValidationUC13.lambda_Expression_To_Check_Phone_Number(mobile_Number);
            Console.WriteLine(result);

            Console.Write("Enter Password = ");
            string password = Console.ReadLine();
            result = lambdaValidationUC13.lambda_Expression_To_Check_Password(password);
            Console.WriteLine(result);
        }
    }
}
