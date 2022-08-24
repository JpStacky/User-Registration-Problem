namespace RegexProblem
{
    public class ProgramUC1
    {
        public static void Main()
        {
            Console.WriteLine("Enter First Name = ");
            string firstName = Console.ReadLine();

            ValidateFirstNameUC1 validateName = new ValidateFirstNameUC1();
            bool result = validateName.Validate(firstName);
            if (result)
                Console.WriteLine("Valid First Name");
            else
                Console.WriteLine("Invalid First Name");
        }
    }
}