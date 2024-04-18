using System;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result = 0;

            Console.WriteLine("What shape would you like to find the area of? \n Press 'r' for rectangle, 'c' for circle, \n 's' for square and 't' for triangle");
            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Enter the height of the rectangle");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the width of the rectangle");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else if (answer == "c")
            {
                Console.WriteLine("Enter the radius of the circle");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * radius;
            }
            else if (answer == "s")
            {
                Console.WriteLine("Enter the length of the square");
                float sideLength = float.Parse(Console.ReadLine());

                result = sideLength * sideLength;
            }
            else if (answer == "t")
            {
                Console.WriteLine("Enter the base length of the triangle");
                float baseLength = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height of the triangle");
                float height = float.Parse(Console.ReadLine());

                result = 0.5f * baseLength * height;
            }
            else
            {
                Console.WriteLine("You did not enter a correct option");
            }

            Console.WriteLine($"The result is {result}");
            Console.ReadKey();
        }
    }
}
