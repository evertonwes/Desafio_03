using System;
using System.Globalization;
namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            float nota = 0;
            string nomeMaiorNota = "";
            float maiorNota = 0;

            Console.Write("Quantos Alunos : ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Nome do Aluno #{0} : ", i);
                nome = Console.ReadLine();
                Console.Write("Qual a nota do aluno #{0} : ", i);
                nota = float.Parse(Console.ReadLine());

                if (nota >= maiorNota)
                {
                    maiorNota = nota;
                    nomeMaiorNota = nome;
                }

            
            }
            Console.WriteLine();
            Console.WriteLine("Aluno com a maior nota é " + nomeMaiorNota + " com a nota " + maiorNota);
            


        }

    }
}
