namespace _04_password_validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            checkPassword(password);
        }

        public static void checkPassword(string password)
        {
            bool characters = false; 
            bool lettersAndDigits = true;  
            bool contains2Digits = false;

            int digitsCount = 0;

            foreach(char symb in password)
            {
                if((int)symb >= 48 && (int)symb <= 57)
                {
                    digitsCount++;

                    if(digitsCount == 2 )
                    {
                        contains2Digits = true;
                    }

                }

                if(password.Length >= 6 && password.Length <= 10)
                {
                    characters = true;
                }

                if (!(((int)symb >= 65 && (int)symb <= 90) || ((int)symb >= 97 && (int)symb <= 122) || ((int)symb >= 48 && (int)symb <= 57)))
                {
                    lettersAndDigits = false;
                }
            }

            if(!characters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if(!lettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!contains2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(characters && lettersAndDigits && contains2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
