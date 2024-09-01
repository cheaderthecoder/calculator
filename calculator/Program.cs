internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Click enter to Start");
        string anser = Console.ReadLine();
        anser.ToUpper();
        while (anser == "" +"" || anser == "Y")
        {
            Console.Clear();
            Console.WriteLine("Welcome Enter in What You Want to do\n");
            Console.WriteLine("enter + for Addition\n");
            Console.WriteLine("enter - for Subtraction\n");
            Console.WriteLine("enter / for Division\n");
            Console.WriteLine("enter * for multiplication\n");
            Console.WriteLine("enter x for multiplication\n");
            Console.WriteLine("");

            string ans = Console.ReadLine();
            Console.WriteLine("Write 2 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3;
            switch (ans)
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
            ans = "";
            Console.WriteLine("do you want to continue (Y/N)");
            anser = Console.ReadLine();
        }
    }
}