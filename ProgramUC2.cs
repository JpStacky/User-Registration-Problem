namespace RegexProblem
{
    public class ProgramUC2
    {
        public static void Main()
        {
            Console.WriteLine("Enter Last Name = ");
            string lastName = Console.ReadLine();

            ValidateLastNameUC2 validateName = new ValidateLastNameUC2();
            bool result = validateName.Validate(lastName);
            if (result)
                Console.WriteLine("Valid Last Name");
            else
                Console.WriteLine("Invalid Last Name");
        }
    }
}
