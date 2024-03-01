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

            //decreased result
            Console.WriteLine(--con_num);
            //increased result
            Console.WriteLine(++con_num);
        }
    }
}
