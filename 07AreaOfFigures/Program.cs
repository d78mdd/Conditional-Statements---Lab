using System;

namespace _07AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();

            if (figura == "square")
            {
                double num = double.Parse(Console.ReadLine());
                double lice = num * num;
                string formatted = lice.ToString("F3");
                Console.WriteLine(formatted);
            }
            else if (figura == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double lice = num1 * num2;
                string formatted = lice.ToString("F3");
                Console.WriteLine(formatted);
            }
            else if (figura == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double lice = Math.PI * num1 * num1;
                string formatted = lice.ToString("F3");
                Console.WriteLine(formatted);
            }
            else if (figura == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double lice = num1 * num2 / 2;
                string formatted = lice.ToString("F3");
                Console.WriteLine(formatted);
            }
        }
    }
}
