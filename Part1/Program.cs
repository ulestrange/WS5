using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.X86;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // looking at String methods 
            // Play with these yourself and see if you
            // understand what is going on.



            string testString1 = "           space before and after     ";
            string testString2 = "looking for characters in this string - are they there?";
           
            string testString3 = "This ends in nny";
            string testString4 = "abcdefghijklmnopqrstuvwxyz";
            string testString5 = "I love Sligo";
            string testString6 = "I love Sligo";

            // 1.	Trim all leading and trailing spaces from any string,
            // outputting the result, and the old and new lengths of the string.

            Console.WriteLine($"{testString1.Trim()}  Old Length : {testString1.Length} New Length: {testString1.Trim().Length}" );


            // 2.	Output the first position of the character “g” in a string. Output the first position of the character “g”
            // in the string starting from position 11. 
            Console.WriteLine("Output the first position of the character “g” in a string" );
            Console.WriteLine(testString2);
            Console.WriteLine(testString2.IndexOf('g'));

            Console.WriteLine("Output the first position of the character “g” in a string starting from position 11");

            Console.WriteLine(testString2);
            Console.WriteLine(testString2.IndexOf('g',10));

            // 3.	Output the first and last character contained in a string. 
            char firstChar = testString2[0];
            char lastChar = testString2[testString2.Length - 1];

            Console.WriteLine(firstChar);
            Console.WriteLine(lastChar);

        

            Console.WriteLine(testString4[0]);
            Console.WriteLine(testString4[testString4.Length - 1]);

            // see below for examples of chaining methods together.
            // 

            Console.WriteLine(testString1.ToUpper().Trim()[0]);

            Console.WriteLine(testString1.ToUpper().ToLower().Trim()[0]);
            Console.WriteLine(testString1.ToLower().ToUpper().Trim()[0]);

            // 4.	Determine if a string ends with the characters “nny”.



            Console.WriteLine(testString1.EndsWith("nny"));
            Console.WriteLine(testString3.EndsWith("nny"));

           

            //5.	Determine if a string is equal to the string: “I love Sligo” ?


            // Note in C# == is overloaded for strings so that the equality operator 
            // works, normally with reference types == will not work unless they are actually
            // refereing to the same object.

            Console.WriteLine("I love Sligo" == testString5);
            Console.WriteLine(testString6 == testString5);

            Console.WriteLine("I love Sligo" == "I love Sligo");

            Console.WriteLine( "I love Sligo".CompareTo(testString5) == 0);

            Console.WriteLine("I love Sligo".CompareTo(testString5));

            Console.WriteLine(testString3 == testString5);

            // 6.Break a string up into individual words and display
            // each word on a separate line on the console and then outputs the number of words in the sentence. (Hint: use the Split method). 

            string[] words = testString3.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(words.Length);

            //7.	Encrypt a string by replacing each occurrence of the letter ‘a’ with ‘b’ and each
            //occurrence of the letter ‘t’ with ‘s’ .
            Console.WriteLine(  testString2.Replace('a', 'b').Replace('t', 's'));

            // Can you figure out which replacement happens first ?

            Console.WriteLine(testString2.Replace('a', 'b').Replace('b', 's'));

            Console.WriteLine(testString2.Replace('s', 'b').Replace('t', 's'));
        }
    }
}