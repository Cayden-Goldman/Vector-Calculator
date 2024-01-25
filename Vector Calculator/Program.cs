using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1;
            string x2;
            string y1;
            string y2;
            string z1;
            string z2;
            Console.WriteLine("Please input an x value for the first vector.");
            x1 = Console.ReadLine();
            Console.WriteLine("Please input an x value for the second vector.");
            x2 = Console.ReadLine();
            Console.WriteLine("Please input an y value for the first vector.");
            y1 = Console.ReadLine();
            Int16.Parse(y1);
            Console.WriteLine("Please input an y value for the second vector.");
            y2 = Console.ReadLine();
            Int16.Parse(y2);
            Console.WriteLine("Please input an z value for the first vector.");
            z1 = Console.ReadLine();
            Int16.Parse(z1);
            Console.WriteLine("Please input an z value for the second vector.");
            z2 = Console.ReadLine();
            Int16.Parse(z2);
            Vector test1 = new Vector(Int16.Parse(x1), Int16.Parse(y1), Int16.Parse(z1));
            Vector test2 = new Vector(Int16.Parse(x2), Int16.Parse(y2), Int16.Parse(z2));
            Console.WriteLine("What function would you like to do with these vector(s)?");
            Console.WriteLine("ADD || SUBTRACT || NEGATE");
            string userInput = Console.ReadLine();
            if (userInput == "add")
            {
                Vector Add(test1, test2)
            }
            
        }
    }
}
