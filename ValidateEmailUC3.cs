using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class ValidateEmailUC3
    {
        public static string validEmail = "^[a-zA-Z0-9]([.]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public bool Validate(string email)
        {
            return Regex.IsMatch(email, validEmail);
        }
    }
}
