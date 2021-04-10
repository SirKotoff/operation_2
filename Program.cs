using System;


namespace T2
{
    class Program
    {
        static void Main()
        {
            Polynom a = new Polynom(new int[4] { 8, -3, 5, 9});
            Polynom b = new Polynom(new int[3] { 9, 4, 1});
            Polynom c = a + b;
            Console.WriteLine($"({a.ToString()}) + ({b.ToString()}) = [{c.ToString()}]");
           Console.ReadKey();
        }
    }
}
