using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of Shots: ");
            //variables
            string input= Console.ReadLine();
            int n = int.Parse(input);

            for(int times = 1; times <= n; times++)
            {
                if (times % 3 == 0 && times % 5 == 0)
                {
                    Console.WriteLine($"{times}: Magic Fire! Electric Fire!");
                    continue;
                }

                else if (times % 3 == 0)
                {
                    Console.WriteLine($"{times}: Magic Fire!");
                }

                else if (times % 5 == 0)
                {
                    Console.WriteLine($"{times}: Electric Fire!");
                }

                else
                {
                    Console.WriteLine($"{times}: Normal fire :/");
                }
            }



        }
    }
}
