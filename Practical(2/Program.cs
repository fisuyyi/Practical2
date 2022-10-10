using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Practical_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zadaca;
            do
            {
                Console.WriteLine("Доступны следующие задачи: \n 1. Игра 'Угадай число' \n 2. Таблица умножения \n 3. Вывод делителей чисел \n 4. Выход ");
                Console.Write("Введите желаемую задачу: ");
                
                zadaca = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                switch (zadaca)
                {
                    case 1:
                        Guess();
                        break;

                    case 2:
                        MultiTable();
                        break;
                    case 3:
                        delitel();
                        break;
                    default:
                        Console.WriteLine("Ошибка! Вы ввели неверный номер операции. \nПожалуйста введите номер операции заново!");
                        break;
                }
            } while (zadaca != 4);
        }



        static void Guess()
        {
            Random ugaday = new Random();
            int i = ugaday.Next(100);
            i = Convert.ToInt32(i);
            int attempt = 0;

            int k;
            Console.WriteLine("Попробуйте угадать число от 0 до 100, загаданное компьютером");
            do
            {
                Console.Write("Введите число: ");
                k = Convert.ToInt32(Console.ReadLine());

                if (k < i)
                    Console.WriteLine("Задуманное число больше");
                    Console.WriteLine();
                if (k > i)
                    Console.WriteLine("Задуманное число меньше");
                  
                attempt++;

            } 
            while (i != k);

            Console.WriteLine("Вы угадали число! Поздравляю! Попыток было потрачено: "+ attempt);
            Console.WriteLine();
        }




        static void MultiTable()
        {
            int[,] multitable = new int[9,10];
            Console.WriteLine("Таблица умножения: ");
            for (int x = 0; x < 9; x++)
            {

                for (int y = 1; y < 10; y++)
                {
                    multitable[x, y] = (x + 1) * y;
                }
            }
            for (int x = 0; x < 9; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.Write(multitable[x, y] + "\t");
                }
                
                Console.WriteLine();
            }
        }



        static void delitel()
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.Write($"{i}   ");
                }
            }
            Console.WriteLine();
        }


    }
}

//int Num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= Num; i++)
//{
//    if (Num % i == 0)
//    {
//        Console.Write($"{i}   ");
//    }
//}
//Console.WriteLine();