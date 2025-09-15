using System;

    class Program
    {
        public static void Main()
        {
            string s;

            Console.Clear();
            s = Console.ReadLine();

            int a = int.Parse(s);

            if (a % 2 == 0)
            {
                Console.WriteLine($"{s} is even");
            }
            else
            {
                Console.WriteLine($"{s} is odd");
            }
        }
    }