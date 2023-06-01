internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the second number:");
        int b = int.Parse(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("EQUAL");
        }
        else {
            Console.WriteLine(" NOT EQUAL ");
        }
        
    }
}