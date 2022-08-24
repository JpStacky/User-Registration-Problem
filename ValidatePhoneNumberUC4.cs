using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class ValidatePhoneNumberUC4
    {
        public string validPhoneNumber = "^[9,1]{2}[ ][0-9]{10}$";
        public bool Validate(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber,validPhoneNumber);
        }
    }
}
