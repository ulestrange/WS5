namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            List<int> numbers2 = new List<int>();

            List<string> names = new List<string>();

            List<bool> answers = new List<bool>();

           numbers[0] = 1;

           numbers2.Add(1);


            numbers[1] = 2;

           numbers2.Add(2);
            numbers2.Add(3);
            numbers2.Add(4);
            numbers2.Add(15);


            numbers2.Remove(1);


            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
            }


            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }



            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers2[0]);
        }
    }
}