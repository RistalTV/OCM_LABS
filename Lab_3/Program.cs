using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{

    class Program
    {
        static void Main(string[] args)
        {
            const int q = 0;//число q
            const int p = 0;//число p

            Console.WriteLine("Лабораторная работа №3.\nМоделирование изменения денежных средств на вкладе\nСкребнев Л.Э.\n");
            task1.start(q, p);
            Console.ReadLine();
            task2.start(q, p);
            Console.ReadLine();
        }
    }

    public class task2
    {
        public static void start(int q, int p)
        {
            int z0 = 100 + 4 * p + 3 * q + 1;  //начальная сумма вклада
            int i = p + q + 1;                 //проценты вклада
            int t = 0;                         //текущий год
            double r = i * 0.01;              //показатель описывающий приращение вклада по сравнению с предыдущим годом
            double y = 0;                          //сумма вклада
            Console.WriteLine();
            
            while (y < 5 * z0)
            {
                y = z0 / r * (1 + 1 / (10 * r)) * Math.Pow(1 + r, t + 1) - (z0 * t) / (10 * r) - z0 / (10 * Math.Pow(r, 2)) * (1 + 11 * r);
                Console.WriteLine("{0} случай: {1}",t+1,y);
                t++;
            }

            Console.WriteLine("Промежуток времени, через который вклад вырастет в 5 раз: " + t + " лет");
            i = p + q + 1;                  //проценты вклада
            t = 5;                          //текущий год
            r = i * 0.01;                   //показатель описывающий приращение вклада по сравнению с предыдущим годом
            y = i * 10;                     //сумма вклада
            double z1= y / (1 / r * (1 + 1 / (10 * r)) * Math.Pow(1 + r, t + 1) - t / (10 * r) - 1 / (10 * Math.Pow(r, 2)) * (1 + 11 * r));

            Console.WriteLine("Минимальная сумма денег, которую нужно положить, чтобы через 5 лет сумма превысила заданную: " + z1);

        }
    }

    public class task1
    {
        public static void start(int q, int p)
        {
            int z0 = 100 + 4 * p + 3 * q + 1;  //начальная сумма вклада
            int i = p + q + 1;          //проценты вклада
            int t = 0;              //текущий год
            double r = i / 100.0;       //показатель описывающий приращение вклада по сравнению с предыдущим годом
            double y;       //сумма вклада
            Console.WriteLine();
            Console.WriteLine("Первый случай:");
            Console.WriteLine("Год Средства");
            do
            {
                y = z0 * Math.Pow(1 + r, t);
                Console.WriteLine("{0,3}    {1,8:f2}", t, y);
                t++;
            }
            while (y < 2 * z0);
            Console.WriteLine("Время, за которое вклад удвоится : {0,3}", t - 1);
            Console.WriteLine("Начальный вклад: {0,8:f2}", z0);

        }
    }
}
