using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_11111
{
     class Program
    {
        static void Main()
        {

            double x;
            double y;
            double z;

            Console.WriteLine("Введите стороны треугольника (без отрицательных чисел и 0)");
            Console.WriteLine();
            Console.Write("Введите сторону x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону z: ");
            z = Convert.ToDouble(Console.ReadLine());

            if ((x <= 0) || (y <= 0) || (z <= 0))
            {
                Console.WriteLine("Одна из сторон <= 0");
                return;
            }

            
            List<double> value = new List<double>() { x, y, z };
            value.Sort();

           
            if ((value[0] + value[1]) <= value[2])
            {
                Console.WriteLine("Сумма двух катетов меньше или равна гипотенузе. Треугольник не может существовать");
                return;
            }
            else Console.WriteLine();

           
            if (x == y && y == z)
                Console.WriteLine("Треугольник равносторонний");
            else if (x != y && y != z && x != z)
                Console.WriteLine("Треугольник разносторонний");
            else if ((x == y) || (x == z) || (y == z))
                Console.WriteLine("Треугольник равнобедренный");
            else
            {
                Console.WriteLine("Неопределённый вид треугольника");
                return;
            }

          
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            Console.WriteLine($"Площадь треугольника S = {S}");
            
            double d = value[0] * value[0] + value[1] * value[1];
            double e = value[2] * value[2];
            if (d - e > 0.00001) Console.WriteLine("Остроугольный треугольник");
            else if (d < e) Console.WriteLine("Тупоугольный треугольник");
            else if (Math.Abs(d - e) < 0.0001) Console.WriteLine("Прямоугольный треугольник");
            else
            {
                Console.WriteLine("Неопределённый вид треугольника");
                return;

                
            }
            Console.ReadKey();  
        }
    }
}

        
    

