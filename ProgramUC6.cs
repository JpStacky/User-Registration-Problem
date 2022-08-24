namespace RegexProblem
{
    public class ProgramUC6
    {
        public static void Main()
        {
            Console.Write("Enter A Password Must Contain 8 Character\n1 Upper Case" + " = ");
            string password = Console.ReadLine();

            PasswordUpperCaseUC6 passwordUpperCaseUC6 = new PasswordUpperCaseUC6();
            bool result = passwordUpperCaseUC6.Validate(password);
            if (result)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
