namespace RegexProblem
{
    public class ProgramUC3
    {
        public static void Main()
        {
            Console.WriteLine("Enter Email = ");
            string email = Console.ReadLine();

            ValidateEmailUC3 validateEmail = new ValidateEmailUC3();
            bool result = validateEmail.Validate(email);
            if (result)
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invalid Email");
        }
    }
}
