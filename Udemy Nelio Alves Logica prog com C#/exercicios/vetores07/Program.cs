using System;
//using System.Globalization;

namespace vetores07
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variável de controle do índice do vetor
            int controle = int.Parse(Console.ReadLine());
            
            //novos vetor que utiliza a variável de controle como índice
            //Variáveis de interesse
            string[] alunos = new string[controle];
            double[] nota1 = new double[controle];
            double[] nota2 = new double[controle];

            //povoando o vetor
            for (int i = 0; i < controle; i++)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    alunos[i] = s[0];
                    nota1[i] = double.Parse(s[1]);
                    nota2[i] = double.Parse(s[2]);

                }
            
            //obtendo a média dos alunos
            double[] soma = new double[controle];
            double[] media = new double[controle];

            for (int i = 0; i < controle; i++)
            {
                soma[i] = nota1[i] + nota2[i];
                media[i] = soma[i] / 2.0;
                //Console.WriteLine(media[i]);
            }
            
            //filtrando os alunos aprovados
            for (int i = 0; i < controle; i++)
            {
                if(media[i] >= 6.0)
                {
                    Console.WriteLine(alunos[i]);
                }
            }
            
            
        }
    }
}
