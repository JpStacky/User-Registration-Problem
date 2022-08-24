﻿using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class PasswordSpecialCharacterUC8
    {
        public static string validPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z])(?=.*[+@#$%^&*!.()-]).{8,}";
        public bool Validate(string password)
        {
            return Regex.IsMatch(password, validPassword);
        }
    }
}
