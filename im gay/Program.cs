using System;

namespace rabota
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.1 Сложный уровень
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = double.Parse(Console.ReadLine());
            if (x <= 1 && x >= -1 && y >= x && y <= 1) Console.WriteLine("yes");
            else Console.WriteLine("no");

        }
           
    }
}
