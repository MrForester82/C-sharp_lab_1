using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_into_VS
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100
        }

        static int sumForTwo(int x, int y)      //ключевое слово static означает, что для вызова данного метода
        {                                       //не требуется создания экземпляра класса
            return x + y;
        }

        static int sumForThree(int x, int y, int z)
        {
            return x + y + z;
        }

        static float multiple(float x, float y)
        {
            return x * y;
        }

        static float devision(float x, float y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!");

            //int i;                    не инициализированная переменная
            //Console.WriteLine(i);

            int i = 1;
            Console.WriteLine(i);
            i = 100;
            Console.WriteLine(i);
            
            /*
            const int i = 1;
            const int x;                 "требуется указать значение типа const"
            Console.WriteLine(i);
            i = 100;                     ошибка
            Console.WriteLine(i);
            */

            Console.WriteLine("Минимальныя температура = " + (int)gradus.min);
            Console.WriteLine("Критическая температура = " + (int)gradus.krit);
            Console.WriteLine("Максимальныя температура = " + (int)gradus.max);

            double a = Math.E;
            Console.WriteLine("e = {0:#.######}\t\te = {0:#.##}", a);

            Console.Write("Введите вещественное число: ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("f = {0:.###}", f);

            ///////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("\t\t\tМеню");
            Console.WriteLine("1. Сумма двух целых чисел");
            Console.WriteLine("2. Перестановка двух целых слагаемых");
            Console.WriteLine("3. Сумма трёх целых чисел");
            Console.WriteLine("4. Произведение двух чисел");
            Console.WriteLine("5. Частное от деления двух чисел");
            Console.WriteLine("6. Приоритет сложения трёх чисел");
            int inum1 = 0;
            int inum2 = 0;
            int inum3 = 0;
            float fnum1 = 0;
            float fnum2 = 0;
            float fnum3 = 0;
            int choice;

            Console.Write("Выберите пункт меню: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите два целых числа");
                    inum1 = int.Parse(Console.ReadLine());
                    inum2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(inum1 + " + " + inum2 + " = " + sumForTwo(inum1, inum2));
                    break;
                case 2:
                    Console.WriteLine("Введите два целых числа");
                    inum1 = int.Parse(Console.ReadLine());
                    inum2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(inum1 + " + " + inum2 + " = " + inum2 + " + " + inum1);
                    break;
                case 3:
                    Console.WriteLine("Введите три целых числа");
                    inum1 = int.Parse(Console.ReadLine());
                    inum2 = int.Parse(Console.ReadLine());
                    inum3 = int.Parse(Console.ReadLine());
                    Console.WriteLine(inum1 + " + " + inum2 + " + " + inum3 + " = " + sumForThree(inum1, inum2, inum3));
                    break;
                case 4:
                    Console.WriteLine("Введите два числа");
                    fnum1 = float.Parse(Console.ReadLine());
                    fnum2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("{0,1:F * {1,1:F} = {2,1:F}", fnum1, fnum2, multiple(fnum1, fnum2));
                    break;
                case 5:
                    Console.WriteLine("Введите два числа");
                    fnum1 = float.Parse(Console.ReadLine());
                    fnum2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("{0,3:F} / {1,3:F} = {2,3:F}", fnum1, fnum2, devision(fnum1, fnum2));
                    break;
                case 6:
                    Console.WriteLine("Введите три числа");
                    fnum1 = float.Parse(Console.ReadLine());
                    fnum2 = float.Parse(Console.ReadLine());
                    fnum3 = float.Parse(Console.ReadLine());
                    Console.WriteLine("({0,2:F} + {1,2:F}) + {2,2:F} = {0,2:F} + ({1,2:F} + {2,2:F})", fnum1, fnum2, fnum3);
                    break;
                default:
                    Console.WriteLine("Такой команды не существует!!");
                    break;
            }
        }
    }
}