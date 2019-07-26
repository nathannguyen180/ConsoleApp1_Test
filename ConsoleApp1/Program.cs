/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator //https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2019#next-steps
    {
        public static double DoOperation(double num1, double num2, string op) 

            //what is this ^ (I also have a second question that can be found if scrolling down)

        {
            double result = double.NaN;
            
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine("Basic Console Calculator (in C#)\r");
                Console.WriteLine("------------------------\n");

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Type a number, and then press Enter");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This isn't valid Chief. Try again: ");
                    numInput1 = Console.ReadLine();
                }


                Console.WriteLine("Type another number, and then press Enter");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This ain't it Chief. Give me a number m8: ");
                    numInput2 = Console.ReadLine();
                }


                Console.WriteLine("Choose an option for the operation:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Substract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divde");
                Console.Write("Your Responds: ");

                string op = Console.ReadLine();
                
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("\n       What you gave me will cause a mathematical error.\n");
                    }
                        else Console.WriteLine("\n      Answer: {0:0.#}\n", result);                                                          // so this is where I will refer back to the first class but why is it " {0:0.##} " ? 
                }
                catch (Exception e)
                {
                    Console.WriteLine("An execption occurred when trying to do the math.\n" + e.Message);
                }


                Console.WriteLine("Press 'n' to close or press Enter again to restart.");
                if (Console.ReadLine() == "n") endApp = true;
                else
                {
                    Console.Clear();
                    Console.Beep();
                }
                
            }
            return;
        }
    }
}
*/