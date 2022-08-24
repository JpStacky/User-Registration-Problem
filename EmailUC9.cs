using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class EmailUC9
    {
        public static string validEmail = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[+@#$%^&*!.()-]).{8,}";
        public bool Validate(string email)
        {
            return Regex.IsMatch(email, validEmail);
        }
    }
}
