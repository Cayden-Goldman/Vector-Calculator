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
            Console.WriteLine("Please input an integer within the 32 bit limit as an x value for the first vector.");
            x1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please input an integer within the 32 bit limit as a y value for the first vector.");
            y1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please input an integer within the 32 bit limit as a z value for the first vector.");
            z1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please input an integer within the 32 bit limit as an x value for the second vector.");
            x2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please input an integer within the 32 bit limit as a y value for the second vector.");
            y2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please input an integer within the 32 bit limit as a z value for the second vector.");
            z2 = Console.ReadLine();
            Console.Clear();
            Vector test1 = new Vector(Int32.Parse(x1), Int32.Parse(y1), Int32.Parse(z1));
            Vector test2 = new Vector(Int32.Parse(x2), Int32.Parse(y2), Int32.Parse(z2));
            Console.WriteLine("What function would you like to do with these vector(s)?");
            Console.WriteLine("ADD || SUBTRACT || NEGATE || SCALE || MAGNITUDE || NORMALIZE || DOTPRODUCT || CROSSPRODUCT || ANGLEBETWEEN || GETDIRECTION || PROJECTONTO");
            string userInput = Console.ReadLine();
            Console.Clear();
            if (userInput.ToLower() == "add")
            {
                Console.WriteLine(test1 + " + " + test2 + " = ");
                Console.WriteLine(Vector.Add(test1, test2));
            }
            else if (userInput.ToLower() == "subtract")
            {
                Console.WriteLine(test1 + " - " + test2 + " = ");
                Console.WriteLine(Vector.Subtract(test1, test2));
            }
            else if (userInput.ToLower() == "negate")
            {
                Console.WriteLine("Which vector would you like to negate?");
                Console.WriteLine("Vector1: " + test1 + "     Vector2: " + test2);
                userInput  = Console.ReadLine();
                if (userInput.ToLower() == "vector1" || userInput == "1")
                {
                    Console.WriteLine(Vector.Negate(test1));
                }
                else if (userInput.ToLower() == "vector2" || userInput == "2")
                {
                    Console.WriteLine(Vector.Negate(test2));
                }
                
            }
            else if (userInput.ToLower() == "scale")
            {
                Console.WriteLine("Which vector would you like to scale?");
                Console.WriteLine("Vector1: " + test1 + "     Vector2: " + test2);
                userInput  = Console.ReadLine();
                Console.Clear();
                if (userInput.ToLower() == "vector1" || userInput == "1")
                {
                    Console.WriteLine("What integer would you like to scale it by?");
                    int scaleValue = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(Vector.Scale(test1, scaleValue));
                }
                else if (userInput.ToLower() == "vector2" || userInput == "2")
                {
                    Console.WriteLine("What integer would you like to scale it by?");
                    int scaleValue = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(Vector.Scale(test2, scaleValue));
                }
                
            }
            else if (userInput.ToLower() == "magnitude")
            {
                Console.WriteLine("Which vector would you like to get the magnitude of?");
                Console.WriteLine("Vector1: " + test1 + "     Vector2: " + test2);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "vector1" || userInput == "1")
                {
                    Console.WriteLine(test1.GetMagnitude());
                }
                else if (userInput.ToLower() == "vector2" || userInput == "2")
                {
                    Console.WriteLine(test2.GetMagnitude());
                }
            }
            else if (userInput.ToLower() == "normalize")
            {
                Console.WriteLine("Which vector would you like to normalize?");
                Console.WriteLine("Vector1: " + test1 + "     Vector2: " + test2);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "vector1" || userInput == "1")
                {
                    Console.WriteLine(Vector.Normalize(test1));
                }
                else if (userInput.ToLower() == "vector2" || userInput == "2")
                {
                    Console.WriteLine(Vector.Normalize(test2));
                }
            }
            else if (userInput.ToLower() == "dotproduct")
            {
                Console.WriteLine(test1 + " • " + test2 + " = ");
                Console.WriteLine(Vector.DotProduct(test1, test2));
            }
            else if (userInput.ToLower() == "crossproduct")
            {
                Console.WriteLine(test1 + " X " + test2 + " = ");
                Console.WriteLine(Vector.CrossProduct(test1, test2));
            }
            else if (userInput.ToLower() == "anglebetween")
            {
                Console.WriteLine("The angle between " + test1 + " and " + test2 + " is:");
                Console.WriteLine(Vector.AngleBetween(test1, test2));
            }
            else if (userInput.ToLower() == "getdirection")
            {
                Console.WriteLine("Which vector would you like to get the direction of?");
                Console.WriteLine("Vector1: " + test1 + "     Vector2: " + test2);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "vector1" || userInput == "1")
                {
                    Console.WriteLine(test1.GetDirection());
                }
                else if (userInput.ToLower() == "vector2" || userInput == "2")
                {
                    Console.WriteLine(test2.GetDirection());
                }
            }
            else if (userInput.ToLower() == "projectonto")
            {
                Console.WriteLine(test1 + " projected onto " + test2 + " is:");
                Console.WriteLine(Vector.ProjectOnto(test1, test2));
            }
            else if (userInput.ToLower() == "derek")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Hello Derek :)");
                userInput = Console.ReadLine();
                Console.Clear();
                if (userInput.ToLower() == "derek?")
                {
                    Console.WriteLine("DEREK >:)");
                    System.Threading.Thread.Sleep(500);
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////");
                }
            }
            
        }
    }
}
