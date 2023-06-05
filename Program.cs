internal class Program
{
    private static void Main(string[] args)
    {
        //--------------------------------------------------------------
        //if-else loops

        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("enter the first number:");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine("enter the second number:");
        //int b = int.Parse(Console.ReadLine());

        //if (a == b)
        //{
        //    Console.WriteLine("EQUAL");
        //}
        //else {
        //    Console.WriteLine(" NOT EQUAL ");
        //}
        //---------------------------------------------------------------
        //multiple condiitons

        //int k = 1, l = 1;
        //int r = 5;

        // bool j;
        // j = k == l;
        //  Console.WriteLine(j); //true

        // if (k >= l) {
        //if (k < l || r == 5) {
        //     Console.WriteLine("condition met.");
        // }
        //else if (k > l)
        //{
        //    Console.WriteLine("else if condition met.");
        //}
        //else
        //{
        //    Console.WriteLine("condition is not met.");
        //}
        //------------------------------------------------------------------
        //Nested loops

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(i);

            }
        }
        //---------------
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 5; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
                if (k < i) Console.Write("_");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}