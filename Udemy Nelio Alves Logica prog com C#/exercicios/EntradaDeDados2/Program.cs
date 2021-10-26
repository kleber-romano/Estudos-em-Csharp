using System;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("ch = " + ch);
            Console.WriteLine("n2 = " + n2);
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("sexo: " + sexo);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("altura: " + altura);
            
            Console.ReadLine();
        }
    }
}
