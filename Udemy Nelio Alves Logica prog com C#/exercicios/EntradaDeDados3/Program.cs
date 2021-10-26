using System;

namespace EntradaDeDados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string[] nomeCompleto = Console.ReadLine().Split(' ');
            string nome = nomeCompleto[0];
            string sobrenome = nomeCompleto[1];

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu sexo, idade, e altura para concluir seu cadastro: ");
            string[] v = Console.ReadLine().Split(' ');
            char sexo = char.Parse(v[0]);
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("++++++    Dados do locatário ++++++++++++");
            Console.WriteLine("Nome: " + nome + "     " + "Sobrenome: " + sobrenome);
            Console.WriteLine("Sexo: " + sexo + "  Idade: " + idade + "  Altura: " + altura);
            Console.WriteLine("Quartos reservados: " + quartos + "   Valor do aluguel: R$" + preco);
            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++");

            Console.ReadLine();
        }
    }
}
