namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue = IsValidCharacters(password) &&
                          IsValidLettersOrDigits(password) &&
                          IsValidTwoDigits(password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }

            if (!IsValidCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsValidLettersOrDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsValidTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool IsValidTwoDigits(string password)
        {
            int count = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        private static bool IsValidLettersOrDigits(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsValidCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
