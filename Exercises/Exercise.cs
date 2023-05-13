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

        public static void Fibonnaci()
        {
            //Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
            //escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e indique se o número informado pertence ou não a sequência:

            //a) Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
            //b) É necessário guardar os números da sequência que estão sendo calculados.
            while (true)
            {
                Console.WriteLine("Informe um número ou 0 para encerrar");
                Console.Write("Digite: ");
                long number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                    break;

                List<long> numbers = new List<long>();
                numbers.Add(0);
                numbers.Add(1);

                Console.Write("Resultado: ");
                for (int i = 0; i < number; i++)
                {
                    var last = numbers.Last();
                    var beforeLast = numbers[numbers.LastIndexOf(last) - 1];
                    var result = last + beforeLast;

                    numbers.Add(result);
                    Console.Write($"{result} ");
                }

                if (numbers.Contains(number))
                    Console.WriteLine("\nO número informado pertence a sequência");

                else
                    Console.WriteLine("\nO número informado não pertence a sequência");
            }
        }

        public static void Distribuidora()
        {
            //Dado um vetor que guarda o valor de faturamento diário de uma distribuidora de todos os dias de um ano, faça um programa, na linguagem que desejar, que calcule e retorne:
            //• O menor valor de faturamento ocorrido em um dia do ano;
            //• O maior valor de faturamento ocorrido em um dia do ano;
            //• Número de dias no ano em que o valor de faturamento diário foi superior à média anual.

            //a) Considerar o vetor já carregado com as informações de valor de faturamento.
            //b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média.
            //c) Utilize o algoritmo mais veloz que puder definir.

            Random rand = new Random();
            var totalDiasUteis = 250;
            decimal[] values = new decimal[totalDiasUteis];


            for (int i = 0; i < values.Length; i++)
            {
                values[i] = rand.Next(3567);
            }

            List<decimal> valuesList = values.ToList();
            var perDay = valuesList.Sum() / totalDiasUteis;
            var numberDays = valuesList.FindAll(x => x > perDay).Count;

            Console.WriteLine($"O menor valor é : {valuesList.Min()}");
            Console.WriteLine($"O maior valor é : {valuesList.Max()}");
            Console.WriteLine($"Numero de dias com maior faturamento: {numberDays}");
        }

        public static void PercentualEstado()
        {
            // Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.

            double SP = 67.836;
            double RJ = 36.678;
            double MG = 29.229;
            double ES = 27.165;
            double Outros = 19.849;

            List<double> values = new List<double>
            {
                SP, RJ, MG, ES, Outros
            };

            double total = 0;
            for (int i = 0; i < values.Count; i++)
            {
                total += values[i];
            }

            Console.WriteLine($"SP: {Calculate(SP)}");
            Console.WriteLine($"RJ: {Calculate(RJ)}");
            Console.WriteLine($"MG: {Calculate(MG)}");
            Console.WriteLine($"ES: {Calculate(ES)}");
            Console.WriteLine($"Outros: {Calculate(Outros)}");

            int Calculate(double number)
            {
                return Convert.ToInt32((number * 100) / total);
            }
        }
    }
}