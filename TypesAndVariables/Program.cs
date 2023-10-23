namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = 'A';
            bool condition = false;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is : {0}", (int)character);

            Console.ReadLine();
        }
    }
}