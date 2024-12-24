using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {/// <summary>
     /// Задача 2. Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
     /// </summary>
     /// <param name="args"></param>
     /// 

        static void Func()
        {
            decimal c = 20.4M;
            decimal c1 = 20.4M;
            for(int x=2;x<=20;x++)
            {
                c1 = c1 + c;
                Console.WriteLine($"{x} шт:\t{c1}");

            }
        }
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
