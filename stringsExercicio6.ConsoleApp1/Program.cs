namespace stringsExercicio6.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Exercicio 6 *****");

            // Explicação Rech
            //precisamos ler o arquivo

            string caminhoArquivo = @"C:\Users\lisa_\source\repos\stringsExercicio1.ConsoleApp\stringsExercicio6.ConsoleApp1\Dados\Cidades - Cidades.csv";
            string arquivo = File.ReadAllText(caminhoArquivo);

            //precisamos pegar as linhas do arquivo

            string[] linhas = arquivo.Split("\r\n");

            //pegar a cidade e o estado : "Lages; Santa Catarina"

            string[] cidadesEhEstados = new string[linhas.Length];

            int posicaoCidade = 2;
            int posicaoEstado = 3;

            int j = 0;
            for (int i = 1; i < linhas.Length; i++)
            {
                string[] colunas = linhas[i].Split(";");

                cidadesEhEstados[j] = colunas[posicaoCidade] + ";" + colunas[posicaoEstado];

                j++;
            }

            //mostrar cidades agrupadas pela letra
            char[] alfabeto = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                   'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            for (int i = 0; i < alfabeto.Length; i++)
            {
                //mostrar o cabeçalho
                Console.WriteLine($"\nCidades com a letra {alfabeto[i]}\n");

                for (int x = 0; x < cidadesEhEstados.Length; x++)
                {
                    char primeiraLetra = alfabeto[i];

                    //verificar se o nome do municipio inicia com a letra selecionada
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].StartsWith(primeiraLetra))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(";");
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }

            Console.Clear();

            string[] estados = new string[]
            {
                "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal",
                "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul",
                "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro",
                "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina",
                "São Paulo", "Sergipe", "Tocantins"
            };

            for (int i = 0; i < estados.Length; i++)
            {
                //mostrar o cabeçalho
                string estado = estados[i];

                Console.WriteLine($"\nCidades do estado: {estado}\n");

                for (int x = 0; x < cidadesEhEstados.Length; x++)
                {
                    if (cidadesEhEstados[x] != null && cidadesEhEstados[x].Contains(estado))
                    {
                        int posicaoInicioEstado = cidadesEhEstados[x].IndexOf(";");
                        string cidadeSemEstado = cidadesEhEstados[x].Remove(posicaoInicioEstado);
                        Console.WriteLine("\t" + cidadeSemEstado);
                    }
                }
            }

            Console.ReadLine();


        }
    }
}