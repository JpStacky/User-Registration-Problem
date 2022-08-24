using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class ValidateUserUC10
    {
        public string validFirstName = "^[A-Z]{1}[a-z]*$";
        public string validLastName = "^[A-Z]{1}[a-z]*$";
        public string validEmail = "^[a-zA-Z0-9]([.]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public string validMobileNumber = "^91[ ][0-9]{10}$";
        public string validPassword = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public string choice;
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, validPassword))
                choice = "Happy";
            else
                choice = "Sad";
            return choice;
        }
        public string ValidateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, validMobileNumber))
                choice = "Happy";
            else
                choice = "Sad";
            return choice;
        }
        public string ValidateEMail(string email)
        {
            if (Regex.IsMatch(email, validEmail))
                choice = "Happy";
            else
                choice = "Sad";
            return choice;
        }
        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, validFirstName))
                choice = "Happy";
            else
                choice = "Sad";
            return choice;
        }
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, validLastName))
                choice = "Happy";
            else
                choice = "Sad";
            return choice;
        }
        public static void Main()
        { 
           
        }
    }
}
