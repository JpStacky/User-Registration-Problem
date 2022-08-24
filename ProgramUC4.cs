namespace RegexProblem
{
    public class ProgramUC4
    {
        public static void Main()
        {
            Console.WriteLine("Enter Phone Number = ");
            string phoneNumer = Console.ReadLine();

            ValidatePhoneNumberUC4 validatePhoneNumber = new ValidatePhoneNumberUC4();
            bool result = validatePhoneNumber.Validate(phoneNumer);
            if (result)
                Console.WriteLine("Valid Phone Number");
            else
                Console.WriteLine("Invalid Phone Number");
        }
    }
}
