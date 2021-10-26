using System;

namespace ProcessamentoDeDadosECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculo de área de um trapézio
            double h = 5.0;
            double b = 6.0;
            double B = 8.0;

            double area = (b + B) / 2 * h;

            Console.WriteLine("A área do trapézio é: " + area);

            //Casting
            int a = 9;
            int d = 2;
            double quociente = a / d;

            Console.WriteLine(quociente);

            quociente = (double)a / d;

            Console.WriteLine(quociente);

            double num1 = 5.0;
            int num2 = (int) num1;

            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}
