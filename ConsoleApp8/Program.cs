using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        
        static void Func()
        {
            int i = 0;
            do
            {
                Console.Write($"{20}\t");
                i++;

            } while (i<10);
        }
   

        


        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }

    }
}
