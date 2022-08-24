namespace RegexProblem
{
    public class ProgramUC8
    {
        public static void Main()
        {
            Console.Write("Enter A Password Must Contain 8 Character\n1 Upper Case \n2 Numeric \n3 Special CHaracter(!@#$%&*) " + " = ");
            string password = Console.ReadLine();

            PasswordSpecialCharacterUC8 passwordSpecialCharacterUC8 = new PasswordSpecialCharacterUC8();
            bool result = passwordSpecialCharacterUC8.Validate(password);
            if (result)
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}
