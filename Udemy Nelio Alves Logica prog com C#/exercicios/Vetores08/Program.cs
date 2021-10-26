using System;
using System.Globalization;

namespace Vetores08
{
    class Program
    {
        static void Main(string[] args)
        {
            int controle = int.Parse(Console.ReadLine());

            double[] altura = new double[controle];
            char[] sexo = new char[controle];

            for (int i = 0; i < controle; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            double maiorAltura = altura[0];
            for (int i = 0; i < controle; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }

            double menorAltura = double.MaxValue;
            for (int i = 0; i < controle; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            double soma = 0;
            int contMulheres = 0;
            int contHomens = 0;

            for (int i = 0; i < controle; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma =  soma + altura[i];
                    contMulheres++;
                } 
                else
                {
                    contHomens++;
                }
            }

            double mediaAlturaMulheres = soma / contMulheres;


            Console.WriteLine("Menor altura: " + menorAltura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura: " + maiorAltura.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Média de altura entre as mulheres: " + mediaAlturaMulheres.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Número de homens: " + contHomens);
        }
    }
}
