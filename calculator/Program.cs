using System.Formats.Asn1;

namespace Calculator.CLI;
internal class ConsoleCalculator
{
    public static int num1 = 0;
    public static int num2 = 0;

    private static void Main(string[] args)
    {
        Console.WriteLine("Click enter to Start");

        string Answer = Console.ReadLine()?.Trim();
        Answer.ToUpper();
        
        while (Answer != "N")
        {
            Console.Clear();
            Console.WriteLine
            (@"
            Welcome Enter in What You Want to do
            enter + for Addition
            enter - for Subtraction
            enter / for Division
            enter * for multiplication
            enter x for multiplication
            ");

            string Oporation = Console.ReadLine()?.Trim();
            Console.WriteLine("Write your Equation...");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = GetValue(Oporation, num1, num2);

            Console.WriteLine("do you want to continue (Y/N)");
            Answer = Console.ReadLine();
        }

        static int GetValue(string Oporation, int num1, int num2)
        {
            int num3 = 0;
            switch (Oporation)
            {
                case "+":
                    num3 = num1 + num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;
                case "-":
                    num3 = num1 - num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;

                case "*":
                    num3 = num1 * num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;

                case "x":
                    num3 = num1 * num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;

                case "/":
                    num3 = num1 / num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;
            }

            return num3;
        }
    }
}