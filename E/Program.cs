using System;
using System.Globalization;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "s";

            while (opc == "s" || opc == "S")
            {
                Console.WriteLine("Ola");
                Console.Write("Nome do aluno: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite as tres notas do aluno: ");
                Console.WriteLine();
                Console.Write("Nota1: ");
                double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Nota2: ");
                double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Nota3: ");
                double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Aluno A = new Aluno(nome, nota1, nota2, nota3);

                Console.WriteLine();
                double notafinal = A.NotaFinal();
                if (notafinal > 60.0)
                {
                    Console.WriteLine("Nota final = " + notafinal.ToString("f2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Nota final = " + notafinal.ToString("f2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Reprovado");
                    double falta = notafinal - 60.0;
                    Console.WriteLine("Faltaram " + falta.ToString("f2", CultureInfo.InvariantCulture) + " Pontos");
                }
                Console.Write("Deseja consultar as notas de outro aluno (s/n) ? ");
                opc = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
