
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LmaoBox
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            var fibNumbers = new List<int> { 1, 1 };

            Console.WriteLine($"initial fibNumbers.Count = {fibNumbers.Count}");
         

            for (int counter = 0; counter < 10; counter++)
            {
                var previousNum1 = fibNumbers[fibNumbers.Count - 2];
                var previousNum2 = fibNumbers[fibNumbers.Count - 2];

                Console.WriteLine($"previousNum1: {previousNum1}");

                fibNumbers.Add(previousNum1 + previousNum2);
                Console.WriteLine($"fibNumbers.Count = {fibNumbers.Count}");
            }
            foreach (var item in fibNumbers)
                Console.WriteLine(item);


            Console.ReadKey();
        }
            
    }
}

