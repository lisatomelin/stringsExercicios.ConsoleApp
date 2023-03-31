namespace strringsExercicio5.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Exercicio  5 *****");

            // correção Thiago

            Console.WriteLine("Escreva uma frase");
            string frase = Convert.ToString(Console.ReadLine());

            // Imprimir a frase em letras maiúsculas;
            ExibirFraseMaiuscula(frase);

            // Imprimir a frase em letras minúsculas;
            ExibirFraseMinuscula(frase);

            // Imprimir a quantidade de caracteres da frase;
            ContarCaracteres(frase);

            string[] fraseSeparada = frase.Split(" ");

            // Imprimir a primeira palavra da frase;
            ExibirPrimeiraPalavra(fraseSeparada);

            // Imprimir a última palavra da frase;
            ExibirUltimaPalavra(fraseSeparada);

            Console.ReadLine();
        }

        private static void ExibirUltimaPalavra(string[] fraseSeparada)
        {
            string ultimaPalavra = fraseSeparada[fraseSeparada.Length - 1];

            Console.WriteLine(ultimaPalavra);
        }

        private static void ExibirPrimeiraPalavra(string[] fraseSeparada)
        {
            string primeiraPalavra = fraseSeparada[0];

            Console.WriteLine(primeiraPalavra);
        }

        private static void ContarCaracteres(string frase)
        {
            int qtdCaracteres = 0;

            for (int caractere = 0; caractere < frase.Length; caractere++)
            {
                if (frase[caractere] != ' ')
                    qtdCaracteres++;
            }

            Console.WriteLine(qtdCaracteres);
        }

        private static void ExibirFraseMinuscula(string frase)
        {
            Console.WriteLine(frase.ToLower()); // ToLower
        }

        private static void ExibirFraseMaiuscula(string frase)
        {
            Console.WriteLine(frase.ToUpper()); // ToUpper
        }
    }
}