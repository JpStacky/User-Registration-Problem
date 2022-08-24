using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class PasswordUpperCaseUC6
    {
        public static string validPassword = "^[a-zA-Z0-9]{8,}$";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password, validPassword);
        }
    }
}
