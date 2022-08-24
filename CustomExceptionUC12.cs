using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class CustomExceptionUC12
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
                throw new InvalidPasswordException("Invalid Passwrd");
            return choice;
        }
        public string ValidateMobileNumber(string mobileNumber)
        {
            if (Regex.IsMatch(mobileNumber, validMobileNumber))
                choice = "Happy";
            else
                throw new InvalidMobileNumberException("Invalid Mobile Number");
            return choice;
        }
        public string ValidateEMail(string email)
        {
            if (Regex.IsMatch(email, validEmail))
                choice = "Happy";
            else
                throw new InvalidEMailIDException("Invalid Email ID");            
            return choice;
        }
        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, validFirstName))
                choice = "Happy";
            else
                throw new InvalidFirstName("Invalid First Name");
            return choice;
        }
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, validLastName))
                choice = "Happy";
            else
                throw new InvalidLastName("Invalid Last Name");
            return choice;
        }
    }
}
