using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LmaoBox
    {
        static void Main()
        {
            Console.WriteLine("");

            int counter = 0;
            while (counter < 999999999)
            {
                Console.WriteLine($"Ayyyyyy Lmao. Counter: {counter}");
                Console.Beep(100, 100);
                counter++;
            }

            Console.ReadLine();
        }
            
    }
}

