using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b ,c, p, area;

            Console.Clear();
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--- Área e Semiperímetro de um triângulo ---");
            Console.ResetColor();

            Console.Write("Lado 1 :");
            a = double.Parse(Console.ReadLine());
            Console.Write("Lado 2 :");
            b = double.Parse(Console.ReadLine());
            Console.Write("Lado 3 :");
            c = double.Parse(Console.ReadLine());

            p = (a + b + c) / 2;
            area = Math.Sqrt(p*(p - a) * (p - b) * (p - c));

            Console.Beep();
            Console.Write($"\nSemiperímetro : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(p);
            Console.ResetColor();
            Console.Write($"Área : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(area);
            Console.ResetColor();


        }
    }
}
