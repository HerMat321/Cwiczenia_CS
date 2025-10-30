internal class Program_2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello World 2!");
        Int32 number = 42;
        Int32 number2 = Int32.Parse(args[0]);
        if (number < number2)
        {
            Console.WriteLine("Napisaliśmy pierwszego ifa!");
        }
    }
}