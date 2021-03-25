using System;

namespace group1_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number of time to reapeat:!");
            string input2 = Console.ReadLine();
            int number = int parse(input2)

            int counter = 0;

            while (counter < number)
            {
                Console.WriteLine(counter);
                Console.WriteLine("Please Enter Your Name!");
                string input = Console.ReadLine();

                Console.WriteLine(input);

                counter++;
            }
                Console.WriteLine("Goodbye");

        }
    }
}
