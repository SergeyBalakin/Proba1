using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько Вам лет");
            int a = int.Parse(Console.ReadLine());

            if (a == 0 )
            {
                Console.WriteLine("В проэкте");
            }

            else if (a == 1 || a <= 5)
            {
                Console.WriteLine("Ребенок");
            }

            else if (a == 6 || a <= 15)
            {
                Console.WriteLine("Подросток");
            }

            else if (a == 16 || a <= 40)
            {
                Console.WriteLine("Взрослый");
            }

            else if (a == 41 || a <= 100)
            {
                Console.WriteLine("Пожилой");
            }

            else if (a >= 100)
            {
                Console.WriteLine("Долгожитель");
            }

            Console.ReadKey();


        }
    }
}
