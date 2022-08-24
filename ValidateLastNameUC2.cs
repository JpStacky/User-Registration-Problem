using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class ValidateLastNameUC2
    {
        public static string validName = "^[A-Z]{1}[a-z]{2}$";
        public bool Validate(string lastName)
        {
            return Regex.IsMatch(lastName, validName);
        }
    }
}