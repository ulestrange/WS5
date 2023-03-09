namespace Part3
{
    internal class Q2
    {
        static void Main(string[] args)
        {

            // using five different  integer arrays to test

            int[] t1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -10 };
            int[] t2 = { 20, 30, 40, 50, 60, 70, 80, 90, 10, 99 };
            int[] t3 = { 1, 2, 3, 114, 5, 6, 7, 8, 9, 10 };
            int[] t4 = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int[] t5 = { };

            try
            {
                double answer = averageTestScore(t1);
                Console.WriteLine($"answer is {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double answer = averageTestScore(t2);
                Console.WriteLine($"answer is {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double answer = averageTestScore(t3);
                Console.WriteLine($"answer is {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double answer = averageTestScore(t4);
                Console.WriteLine($"answer is {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double answer = averageTestScore(t5);
                Console.WriteLine($"answer is {answer}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // using a list of integers arrays to test

            List<int[]> testList = new List<int[]>();

            testList.Add(t1);
            testList.Add(t2);
            testList.Add(t3);
            testList.Add(t4);
            testList.Add(t5);

            foreach (int[] anArray in testList)
            {
                try
                {
                    double answer = averageTestScore(anArray);
                    Console.WriteLine($"answer is {answer}");
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine("Arithemetic Exception " + ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Argument Exception " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

            /// <summary>
            /// Takes an array of integers between 0-100
            /// must have 10 integers
            /// </summary>
            /// <param name="scores"></param>
            /// <returns></returns>
            /// <exception cref="ArithmeticException"></exception>
            /// <exception cref="ArgumentException" ></exception>

            static double averageTestScore(int[] scores)
        {
            double total = 0; // double is a total so the average will work
           

            if (scores.Length == 0)
            {
                throw new ArithmeticException("must have at least one score");
            }

            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (scores[i] < 0 || scores[i] > 100)
                    {
                        throw new ArgumentException($"Test score {i + 1} is {scores[i]} which is out of range");
                       
                    }
                    total += scores[i];
                }


                return total / scores.Length;
            }

            
        }
      

    }
}