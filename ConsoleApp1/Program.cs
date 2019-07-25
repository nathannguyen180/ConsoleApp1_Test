using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suuuu Woop");
          
            for (; ; )
            {
                float num1 = 0; float num2 = 0;

                Console.WriteLine("\n\n------------------------");
                Console.WriteLine("Basic Console Calculator (in C#)\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Type a number, and then press Enter");
                num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Type another number, and then press Enter");
                num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Choose an option for the operation:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Substract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divde");
                Console.Write("Your Responds: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"Answer: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine($"Answer: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine($"Answer: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "/":
                        // Ask the user to enter a non-zero divisor until they do so.
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;

                }
                Console.WriteLine("Press any key to restart");
                Console.ReadKey();
                Console.Clear();
                Console.Beep();
             }
            
        }
    }
}
