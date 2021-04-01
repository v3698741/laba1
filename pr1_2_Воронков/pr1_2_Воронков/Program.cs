using System;

namespace pr1_2_Воронков
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение d: ");
            double d = double.Parse(Console.ReadLine());

            double func = Math.Pow((a + b / c + d), 2) + Math.Pow(b,2);

            Console.WriteLine("Значение выражения: " + func);
            Console.ReadLine();
        }
    }
}
