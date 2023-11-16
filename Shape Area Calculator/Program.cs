using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result = 0;

            Console.WriteLine("Enter 'r' to find the area of a rectangle.");
            Console.WriteLine("Enter 'c' to find the area of a circle.");

            answer = Console.ReadLine() ?? "";

            if (answer == "r")
            {
                Console.WriteLine("Enter the height of the rectangle.");
                // adding "!" tells compiler that this value cannot be null
                float height = float.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter the width of the rectangle.");
                float width = float.Parse(Console.ReadLine()!);

                result = height * width;
            }
            else if (answer == "c")
            {
                Console.WriteLine("Enter the radius of the circle.");
                float radius = float.Parse(Console.ReadLine()!);

                result = (float)Math.PI * (radius * radius);
            }
            else
            {
                Console.WriteLine("Invalid entry.");
            }

            Console.WriteLine("The area is " + result);
        }
    }
}