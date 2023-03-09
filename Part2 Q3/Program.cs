using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Part2_Q3
{
    internal class Program
    {

       // 3.	Write a program that asks the user to enter a series of numbers
       // separated by commas e.g.:  7,9,10,2,18,6   The program should calculate and
       // display the sum of the numbers.

        // This uses exception handling to fail gracefully when the input includes
        // non ints.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a list of integers separated by ,");
           
            string? input = Console.ReadLine();


            try
            {
                int answer = getSumOfNumbersFromString(input);

                Console.WriteLine(answer);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"One of the inputs was wrong {ex.Message}");
            }
        }

        static int getSumOfNumbersFromString(string s1)
        {
            string[] digits = s1.Split(',');

            int number;
            int answer = 0;
         

            foreach (string digit in digits)
            {
                if (int.TryParse(digit, out number))
                {
                    answer += number;
                }
                else
                {
                    throw new ArgumentException($"One of the inputs doesn't parse to an int: {digit}");
                }
            }

            return answer;
        }
  
    }
}