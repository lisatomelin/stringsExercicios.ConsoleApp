using System.Runtime.ConstrainedExecution;
using System;

namespace stringsExercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva uma aplicação troque cada letra de um texto por outra do alfabeto X posições a frente, onde X pode
            //ser escolhido por você(cifra de César)
            //a.Exemplo com X = 2:
            //b. “DIEGO” passará a ser “FKGIQ”

            Console.WriteLine("***** Exercicio 3 *****");

            Console.WriteLine("Escreva um texto para codificar:");
            string texto = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Escolha um valor de X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            char[] letrasDoTexto = new char [texto.Length];
            char[] letrasDoCodigo = new char[texto.Length];

            letrasDoTexto = texto.ToCharArray();
            for (int i = 0; i < letrasDoTexto.Length; i ++)
            {
                int letrasint = letrasDoTexto[i];
                int codigoint = letrasint + x;

                letrasDoCodigo[i] = Convert.ToChar(codigoint);
            }

            Console.WriteLine();
            string codigo = string.Join(" ", letrasDoCodigo);

            Console.WriteLine("O texto após decodificação:" + codigo);

            Console.WriteLine();
            
        }
    }
}