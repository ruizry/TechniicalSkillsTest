using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethods helpers = new TestMethods();

            int[] numArray = new int[] { 5, 3, 4, 2 };

            Console.WriteLine("Values in the array to be used in the next demonstration");
            foreach (int x in numArray)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n\nSum of all odd numbers in this array");
            Console.WriteLine("Result: " + helpers.addOdds(numArray));

            int[] numArray2 = new int[] { 500000000, 300000000, 400000000, 20000000 };

            Console.WriteLine("\nValues in the array to be used in the next demonstration");
            foreach (int x in numArray2)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("\n\nSum of all very large numbers in this array");
            Console.WriteLine("Result: " + helpers.largeSum(numArray2));

            string stringinput3 = "";

            Console.WriteLine("\nPlease enter a string that will be reversed");
            stringinput3 = Console.ReadLine();
            Console.WriteLine("Result: " + helpers.reverseString(stringinput3));

            string stringinput4 = "";

            Console.WriteLine("\nPlease enter a string and all duplicate letters will be removed");
            stringinput4 = Console.ReadLine();
            Console.WriteLine("Result: " + helpers.dupelessString(stringinput4));

            Console.WriteLine("\nFizz Buzz Test - Any number divisible by 3 will show fizz. Any number divisible by 5 will show buzz");
            Console.WriteLine("Press enter to display 100 results from the Fizz Buzz test.");
            Console.ReadLine();
            helpers.fizzbuzz();


            Console.WriteLine("\nEnd of the program, press enter to exit");
            Console.ReadLine();
        }
    }

    public class TestMethods
    {

        public int addOdds(int[] numArray)
        {
            return numArray.Where(n => n % 2 == 1).Sum();
        }

        public double largeSum(int[] numArray)
        {
            double largesum = (double)(numArray.Sum());
            return largesum;
        }

        public string reverseString(string stringIn)
        {
            int length = stringIn.Length;
            char[] letters = new char[length];

            for (int i = 0; i < length; i++)
            {
                letters[i] = stringIn.ElementAt((length - 1) - i);
            }

            return new string(letters);
        }

        public string dupelessString(string stringIn)
        {
            return new string(stringIn.ToCharArray().Distinct().ToArray());
        }

        public void fizzbuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
