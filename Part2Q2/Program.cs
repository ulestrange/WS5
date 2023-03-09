namespace Part2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //some tests to test 2 different methods for checking the password

            // should fail
            string t1 = "123456"; // no upper or lower
            string t2 = ""; //empty string
            string t3 = "wdDv5"; // too short
            string t4 = "werted"; // no upper
            string t5 = "GFRTDD"; // no lower

            // should pass

            string t6 = "Qqwert";
            string t7 = "QWEfLO";

            Console.WriteLine("Expect False");

            Console.WriteLine(isValidPassword(t1));
            Console.WriteLine(isValidPassword2(t1));
            Console.WriteLine(isValidPassword(t2));
            Console.WriteLine(isValidPassword2(t2));
            Console.WriteLine(isValidPassword(t3));
            Console.WriteLine(isValidPassword2(t3));
            Console.WriteLine(isValidPassword(t4));
            Console.WriteLine(isValidPassword2(t4));
            Console.WriteLine(isValidPassword(t5));
            Console.WriteLine(isValidPassword2(t5));

            Console.WriteLine("Expect True");
            Console.WriteLine(isValidPassword(t6));
            Console.WriteLine(isValidPassword2(t6));
            Console.WriteLine(isValidPassword(t7));
            Console.WriteLine(isValidPassword2(t7));

        }

        /// <summary>
        /// Takes a string and returns true if it is at least 6 characters
        /// and contains one upper and one lower case character. Otherwise it
        /// returns false
        /// </summary>
        /// <param name="aString"></param>
        /// <returns></returns>
        static bool isValidPassword(string aString)
        {
            bool isValid = true;
            if (aString.Length < 6)
            {
                isValid = false;
            }
            else if (aString.ToUpper() == aString)
            {
                isValid = false;
            }
            else if (aString.ToLower() == aString)
            {
                isValid = false;
            }

            return isValid;

        }

        /// <summary>
        /// Takes a string and returns true if it is at least 6 characters
        /// and contains one upper and one lower case character. Otherwise it
        /// returns false
        /// </summary>
        /// <param name="aString"></param>
        /// <returns></returns>
        static bool isValidPassword2(string aString)
        {
           return (aString.Length >= 6 && aString.ToUpper() != aString
                && aString.ToLower() != aString);   
        }
    }
}