namespace RegexProblem
{
    public class ProgramUC7
    {
        public static void Main()
        {
            Console.Write("Enter A Password Must Contain 8 Character\n1 Upper Case \n2 Numeric" + " = ");
            string password = Console.ReadLine();

            PasswordNumericUC7 passwordNumericUC7 = new PasswordNumericUC7();
            bool result = passwordNumericUC7.Validate(password);
            if (result)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
