using System.Diagnostics.Metrics;
using System.Drawing;

namespace Exercises
{
    public class Exercise
    {
        public static void ImparPar()
        {
            // Crie um programa que receba uma lista de números e retorne apenas os números pares.
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Digite um número!");
                Console.WriteLine("Digite 0 se deseja sair");
                var option = Convert.ToInt32(Handler.NotEmpty());

                if (option == 0)
                    break;

                else
                    numbers.Add(option);
            }

            if (numbers.Count == 0)
                Console.WriteLine("Nenhum número foi adicionado");

            else
            {
                Console.WriteLine("Numeros pares");
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                        Console.WriteLine(numbers[i]);
                }
            }
        }

        public static void MaiorNome()
        {
            // Crie um programa que leia uma lista de nomes e retorne o nome mais longo.

            var biggest = 0;
            string biggestName = default;

            while (true)
            {
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("Digite o nome");
                Console.Write("Digite: ");
                var name = Console.ReadLine();

                if (name == "0")
                    break;

                if (name.Length > biggest)
                {
                    biggest = name.Length;
                    biggestName = name;
                }
            }

            Console.WriteLine($"O maior nome é {biggestName} pois tem {biggest} dígitos");
        }

        public static void Palindromo()
        {
            // Crie uma função que receba uma string e verifique se ela é um palíndromo.
            while (true)
            {

                Console.WriteLine("Digite algo para ver se é um palíndromo ou 0 para sair");
                Console.Write("Digite: ");
                var text = Console.ReadLine();

                if (text == "0") break;

                else
                {
                    var invertedText = "";
                    var index = text.Length - 1;

                    for (int i = 0; i < text.Length; i++)
                        invertedText += text[index--];

                    if (invertedText == text)
                        Handler.Sucess($"{text} é um palíndromo");

                    Console.WriteLine($"Original: {text} | Invertido: {invertedText}");
                }
            }
        }

        public static void MediaValores()
        {
            // Crie uma função que receba uma lista de números e retorne a média dos valores.
            var total = 0;
            var qtd = 0;

            while (true)
            {
                Console.WriteLine("Digite um número ou 0 para sair");
                var number = Convert.ToInt32(Handler.NotEmpty());

                if (number == 0) break;

                else
                {
                    total += number;
                    qtd++;
                }
            }

            Console.WriteLine("Média é " + total / qtd);
        }

        public static void Fatorial()
        {
            // Crie um programa que calcule o fatorial de um número.
            while (true)
            {
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("Digite o número para ver seu fatorial");
                var number = Convert.ToInt32(Handler.NotEmpty());

                if (number == 0) break;

                var decrementer = number;
                var antecessor = number - 1;
                var result = decrementer * antecessor;

                for (int i = 1; i < number; i++)
                {
                    Console.WriteLine($"{decrementer--} * {antecessor--}");

                    if (antecessor <= 0) break;

                    result = result * antecessor;
                }
                Console.WriteLine($"Resultado é: {result}");
            }
        }

        public static void SegundoMaiorNumero()
        {
            // Crie um programa que receba uma lista de números e retorne o segundo maior número.
            var number = 0;
            var biggestOne = 0;
            var biggestTwo = 0;

            while (true)
            {
                Console.WriteLine("Digite 0 para sair");
                Console.WriteLine("Digite um número");
                number = Convert.ToInt32(Handler.NotEmpty());

                if (number == 0) break;

                if (number > biggestOne)
                {
                    biggestTwo = biggestOne;
                    biggestOne = number;
                }
                if (number > biggestTwo && number < biggestOne) biggestTwo = number;

                Console.WriteLine($"1º: {biggestOne} | 2º: {biggestTwo}");
            }

            Console.WriteLine("O maior número é " + number);
        }

        public static void ArquivoTexto()
        {
            // Crie um programa que leia um arquivo de texto e conte quantas vezes cada palavra aparece.
            var path = @$"{Directory.GetCurrentDirectory()}..\..\..\..\textos.txt";

            if (File.Exists(path) == false)
                File.Create(path).Close();

            var data = File.ReadAllText(path).Split(" ");
            List<object> result = new List<object>();

            for (int i = 0; i < data.Length; i++)
            {
                var content = data[i];
                var qtd = 0;

                for (int j = 0; j < data.Length; j++)
                {
                    if (data[j] == content) qtd++;
                }
                var obj = new { Texto = content, Quantidade = qtd };

                if (result.Contains(obj) == false)
                    result.Add(obj);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}