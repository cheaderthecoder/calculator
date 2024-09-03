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
            Enter what Math oporation to do:

            1.Addition
            2.Subtraction
            3.Division
            4.multiplication
            ");

            string Oporation = Console.ReadLine()?.Trim();
            Console.WriteLine("Write your Equation (aka write 1[enter] 2[enter]) = 3 if you chose Addition (to learn more checkout https://github.com/cheaderthecoder/calculator)...");

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
                case "1":
                    num3 = num1 + num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;
                case "2":
                    num3 = num1 - num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;

                case "3":
                    num3 = num1 / num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;

                case "4":
                    num3 = num1 * num2;
                    Console.WriteLine("\n" + num3 + "\n");
                    break;
            }

            return num3;
        }

    }
}