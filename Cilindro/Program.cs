using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask Input of both height and radius
            Console.Write("Define the cylinder's height: ");
            string a = Console.ReadLine();

            Console.Write("Now define its radius: ");
            string r = Console.ReadLine();
            
            //To floats
            
            float a_float = float.Parse(a);
            float r_float = float.Parse(r);
            //Calculate Volume and Area
            float volume = MathF.PI + MathF.Pow(r_float,2) * a_float;
            float area = 2 * MathF.PI * r_float * (r_float + a_float);
            
            //Show Volume and Area
            Console.WriteLine($"Cylinder's Volume: {volume}");
            Console.WriteLine($"Cylinder's Surface Area: {area}");

            
        }
    }
}
