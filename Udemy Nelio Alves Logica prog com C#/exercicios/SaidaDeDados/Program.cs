using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            Console.WriteLine(" Boa tarde! Cara, que calorão!");
            Console.WriteLine("Que venham dias dias mais amenos!");

            double x = 15.89756;
            double y = 17.96734;
            double z = 12.85736;

            double sum = x + y + z;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F3"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sum.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("x = " + x.ToString("F2") + ", y = " + y.ToString("F2") + ", e z = " + z.ToString("F2"));
        }
    }
}
