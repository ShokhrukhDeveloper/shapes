using System;

class Program
{
    static void DrawCircle(int radius)
    {
        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                if (x * x + y * y <= radius * radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    static void DrawRectangle(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    static void DrawTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
       start: Console.WriteLine("Select a shape:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");

        Console.Write("Enter the number corresponding to the shape: ");
        char choice = Console.ReadKey().KeyChar;

        Console.WriteLine(); // Move to the next line

        switch (choice)
        {
            case '1':
                Console.Write("Enter the radius of the circle: ");
                int circleRadius = int.Parse(Console.ReadLine()!);
                DrawCircle(circleRadius);
                break;
            case '2':
                Console.Write("Enter the width of the rectangle: ");
                int rectangleWidth = int.Parse(Console.ReadLine()!);
                Console.Write("Enter the height of the rectangle: ");
                int rectangleHeight = int.Parse(Console.ReadLine()!);
                DrawRectangle(rectangleWidth, rectangleHeight);
                break;
            case '3':
                Console.Write("Enter the height of the triangle: ");
                int triangleHeight = int.Parse(Console.ReadLine()!);
                DrawTriangle(triangleHeight);
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid number.");
                break;
            
        }
    
        last:Console.WriteLine("Do you want to continue? Yes (y)  No (n)");
        char c=Console.ReadKey().KeyChar;
        if (c=='y')
        {
            Console.Clear();
            goto start;
        }
        else if (c!='n')
        {
            goto last;
        }
        
    }
}

