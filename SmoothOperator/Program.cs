using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the input
            Console.Write("Type an non negative integer: ");
            string num = Console.ReadLine();

            //converting string to byte
            byte con_num = byte.Parse(num);

            //decrement result
            Console.WriteLine(--con_num);
            //increment result
            Console.WriteLine(++con_num);

            //Divide by 2
            Console.WriteLine(con_num/2);
            //Shift left by 3
            Console.WriteLine(con_num << 3);
            //Xor with 5
            Console.WriteLine(con_num^5);
            //if > 10
            if (con_num > 10)
            {
                Console.WriteLine(5 > 2);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
