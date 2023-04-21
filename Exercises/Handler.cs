namespace Exercises
{
    public class Handler
    {
        public static string NotEmpty()
        {
            string message = default;
            var checking = true;
            while (checking)
            {
                Console.Write("Digite: ");
                message = Console.ReadLine();

                if (string.IsNullOrEmpty(message) == false)
                    checking = false;
                else
                    Error();
            }
            return message;
        }

        public static void Error(string message = "Digite algo")
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Sucess(string message = "Concluído")
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
