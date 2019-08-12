using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    class ProgramCS
    {
        static void Main(string[] args)
        {
            int someint = 1;
            float somefloat = 1f;
            bool somebool = false;

            string productName = "TV";
            int productYear = 2012;
            float productPrice = 279.99f;

            /*int guess = 500;
            if (guess == 500)
            {
                Console.WriteLine("Success");
            }*/

            int[] nums = { 1, 2, 3, 4, 5, 6 };

            int[] emptyNums = new int[10];
            Console.WriteLine(emptyNums.Length);
            Console.ReadKey();
            int firstNumber = emptyNums[0];
            int secondNumber = emptyNums[1];
            emptyNums[2] = 10;
            int [,] twoD = new int [2,2];
            twoD[0, 0] = 1;
            twoD[0, 1] = 2;
            twoD[1, 0] = 3;
            twoD[1, 1] = 4;
            int[,] predefindedtwoD = new int[2, 2] { { 1, 2 }, { 3, 4 } };

           // string[] fruits = { "apple", "banana", "orange" };

            /*for (int i = 0; i<3; i++) {

                Console.WriteLine(fruits[i]);
                Console.ReadKey();

            }
            Console.ReadKey();*/

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            int[] array = new int[] { 1, 2, 3 };
            numbers.AddRange(array);

            List<string> fruits = new List<string>();

            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");

            fruits.RemoveAt(1);
            Console.WriteLine($"fruit count: {fruits.Count}");

            List<string> food = new List<string>();
            food.Add("banana");
            food.Add("orange");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            food.AddRange(vegetables);
            Console.WriteLine($"food count: {food.Count}");
            Console.ReadKey();

            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("Alex", 415434543);//
            phonebook["Jessica"] = 415984588;// both of these are methods of adding to the dictionary

            if (phonebook.ContainsKey("Alex"))
            {

            }

        }
    }
}
