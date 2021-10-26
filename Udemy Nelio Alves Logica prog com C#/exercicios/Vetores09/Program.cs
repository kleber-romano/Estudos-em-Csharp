using System;
using System.Globalization;

namespace Vetores09
{
    class Program
    {
        static void Main(string[] args)
        {
            int controle = int.Parse(Console.ReadLine());

            string[] produtos = new string[controle];
            double[] custo = new double[controle];
            double[] preco = new double[controle];

            for (int i = 0; i < controle; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = s[0];
                custo[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                preco[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            int lucroBaixo = 0;
            int lucroMedio = 0;
            int lucroAlto = 0;

            for (int i = 0; i < controle; i++)
            {
                if (preco[i]/custo[i] - 1.0 < 0.1)
                {
                    lucroBaixo++;
                }
                else if(preco[i]/custo[i] - 1.0 > 0.1 && preco[i]/custo[i] - 1.0 < 0.2)
                {
                    lucroMedio++;
                }
                else
                {
                    lucroAlto++;
                }
            }

            double compra = 0;
            double venda = 0;
            for (int i = 0; i < controle; i++)
            {
                compra = compra + custo[i];
                venda = venda + preco[i];
            }

            double lucroTotal = venda - compra;

            Console.WriteLine("Lucro abaixo de 10%: " + lucroBaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroMedio);
            Console.WriteLine("Lucro acima de 20%: " + lucroAlto);
            Console.WriteLine("Valor total de compra: " + compra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + venda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de lucro: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
