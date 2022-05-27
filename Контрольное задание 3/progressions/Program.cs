using System;

namespace progressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progression;

            Console.Write("Введите первое число: ");
            int first_number_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите разность арифметической прогрессии: ");
            int d_1 = Convert.ToInt32(Console.ReadLine());

            progression = new ArithmeticProgression(first_number_1, d_1);

            Console.Write("Введите n число: ");
            Console.WriteLine(progression.SumElement(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine();

            Console.Write("Введите первое число: ");
            int first_number_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите разность геометрической прогрессии: ");
            int d_2 = Convert.ToInt32(Console.ReadLine());

            progression = new GeometricProgression(first_number_2, d_2);

            Console.Write("Введите n число: ");
            Console.WriteLine(progression.SumElement(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
