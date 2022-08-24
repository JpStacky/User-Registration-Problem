namespace RegexProblem
{
    public class ProgramUC5
    {
        public static void Main()
        {
            Console.WriteLine("Enter A Password Must Contain 8 Character = ");
            string password = Console.ReadLine();

            Char8PasswordUC5 char8PasswordUC5 = new Char8PasswordUC5();
            bool result = char8PasswordUC5.Validate(password);
            if (result)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
