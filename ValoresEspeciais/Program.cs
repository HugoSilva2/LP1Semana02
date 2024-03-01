using System;
using System.Security.Cryptography.X509Certificates;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Minimum Values
            int i1 = int.MinValue;
            float fl1 = float.MinValue;
            sbyte sb1 = sbyte.MinValue;
            double db1 = double.MinValue;
            ulong ul1 = ulong.MinValue;
            Console.WriteLine(i1);
            Console.WriteLine(fl1);
            Console.WriteLine(sb1);
            Console.WriteLine(db1);
            Console.WriteLine(ul1);

            //Maximum Values
            int i2 = int.MaxValue;
            float fl2 = float.MaxValue;
            sbyte sb2 = sbyte.MaxValue;
            double db2 = double.MaxValue;
            ulong ul2 = ulong.MaxValue;
            Console.WriteLine(i2);
            Console.WriteLine(fl2);
            Console.WriteLine(sb2);
            Console.WriteLine(db2);
            Console.WriteLine(ul2);


            //Special Values
            double a = double.PositiveInfinity;
            double b = double.NegativeInfinity;
            double x = double.PositiveInfinity / double.PositiveInfinity;
            float y = float.NaN;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
