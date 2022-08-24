using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class ValidateFirstNameUC1
    {
        public static string validName = "^[A-Z]{1}[a-z]*$";
        public bool Validate(string firstName)
        { 
            return Regex.IsMatch(firstName,validName);
        }
    }
}
