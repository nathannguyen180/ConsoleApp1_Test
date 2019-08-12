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
            phonebook.Add("sam", 415478943);
            phonebook.Add("lmaobox", 415324543);
            phonebook.Add("dan", 456148543);

            if (phonebook.ContainsKey("Alex"))
            {
                Console.WriteLine("alec's number =" + phonebook["Alex"]);

            }

            //the real benefit to using dictionary over list is the power to remove keys connected to numbers instead of the large numbers themselves
            phonebook.Remove("Jessica");
            Console.WriteLine(phonebook.Values);
            Console.WriteLine();
           /* for (int i = 0; i < phonebook.Count; i++)
            {
                Console.WriteLine(phonebook[i]);   //this is not possible
            }*/
            Console.WriteLine(phonebook.Count);
            Console.ReadKey();


            
                Dictionary<string, int> inventory = new Dictionary<string, int>();
                inventory["apple"] = 3;
                inventory["orange"] = 5;
                inventory["banana"] = 2;

                Console.WriteLine(inventory["apple"]);
                Console.WriteLine(inventory["orange"]);
                Console.WriteLine(inventory["banana"]);
            Console.ReadLine();

            string emptyString = String.Empty; //read only? is this cringe?

            int integer = 1;
            string ourString = "Something to be replaced by an int"; //is completely replaced so now it only outputs "1"
            ourString = integer.ToString();
            Console.WriteLine(ourString);
            Console.ReadLine();

            int x = 2, y = 2;
            int sum = x + y;
            string sumCalculation = String.Format("{0} + {1} = {2}", x, y, sum);
            Console.WriteLine(sumCalculation);
            Console.ReadLine();

            string fullString = "full string";
            string someString = fullString.Substring(5);
            string shorter = fullString.Substring(5, 3);
            Console.WriteLine(someString);
            Console.WriteLine(shorter);
            Console.ReadLine();
        }
    }
}
