namespace RegexProblem
{
    public class ProgramUC9
    {
        public static void Main()
        {
            Console.Write("Enter A Password Must Contain 8 Character\n1 Upper Case \n2 Numeric \n3 Special CHaracter(!@#$%&*) " + " = ");
            string email = Console.ReadLine();

            EmailUC9 emailUC9 = new EmailUC9();
            bool result = emailUC9.Validate(email);
            if (result)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
