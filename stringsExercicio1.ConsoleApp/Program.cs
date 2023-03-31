using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace stringsExercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Escreva um programa que receba uma frase do usuário e converta todas as 
            ///palavras para o formato "Title Case", ou 
            //seja, todas as primeiras letras das palavras devem ser maiúsculas.

            Console.WriteLine("***** Exercicio 1 *****");
            Console.WriteLine("Escreva uma frase:");
            string mensagem = Console.ReadLine();

            Console.WriteLine();

            string[] palavras = mensagem.Split(' ');


            string[] palavrasTitleCase = new string[mensagem.Length];
            for (int i = 0; i < palavras.Length; i++)
            {
                string primeiraLetra = palavras[i].Substring(0, 1).ToUpper();
                string restoDaPalavra = palavras[i].Substring(1);
                palavrasTitleCase[i] = primeiraLetra + restoDaPalavra;
            }

            string novamensagem = string.Join(" ", palavrasTitleCase);

            Console.WriteLine("Frase em TitleCase: ");
            Console.WriteLine(novamensagem);
        }    
    }
}