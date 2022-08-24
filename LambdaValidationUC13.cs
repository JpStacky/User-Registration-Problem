using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class LambdaValidationUC13
    {
            public string validFirstName = "^[A-Z]{1}[a-z]*$";
            public string validLastName = "^[A-Z]{1}[a-z]*$";
            public string validEmail = "^[a-zA-Z0-9]([.]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
            public string validMobileNumber = "^91[ ][0-9]{10}$";
            public string validPassword = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$";

            public string lambda_Expression_To_Check_Password(string password)
            => Regex.IsMatch(password, validPassword) ? "Password is Valid" : "Password is Not Valid";
            
            public string lambda_Expression_To_Check_Phone_Number(string mobileNumber) 
            => Regex.IsMatch(mobileNumber, validMobileNumber) ? "phno is Valid" : "phno is not Valid";

            public string lambda_Expression_To_Validate_Email(string email)
            => Regex.IsMatch(email, validEmail)?"Email Is Valid":"Email Is Not Valid";

            public string lambda_Expression_To_Check_First_Name(string firstName)
            => Regex.IsMatch(firstName, validFirstName) ? "First Name is Valid" : "First Name is Not Valid";

            public string lambda_Expression_To_Check_Last_Name(string lastName)
            => Regex.IsMatch(lastName, validLastName) ? "Last Name Is Valid" : "Last Name is Not Valid";  
    }
}

