namespace stringsExercicio2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Dada uma string contendo uma frase, escreva um programa em C# que conte o número de palavras na frase e 
            //imprima o resultado.

            Console.WriteLine("***** Exercicio 2 *****");
            Console.WriteLine("Escreva uma frase:");
            string mensagem = Console.ReadLine();

            Console.WriteLine();

            string[] palavras = mensagem.Split(' ');
            int totalPalavras = palavras.Length;

            Console.WriteLine($"A frase contém: {totalPalavras} palavras");
        }
    }
}