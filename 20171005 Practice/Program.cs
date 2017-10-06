using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171005_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //using debug to check nested loops

            // Make a multiplication table

            //for (int i = 1; i<=5; i++)
            //{
            //    Console.Write(i + "\t");                
            //    for (int j = 1; j <=5; j++)
            //    {
            //        Console.Write("\t" + j * i);
            //    }
            //    Console.WriteLine();
            //}


            //Practicing looping w. Arrays
            string[] favoriteHolidays = { "Halloween", "Thanksgiving", "New Year's", "Valentine's Day" };
            //foreach (string holiday in favoriteHolidays)
            //{
            //    Console.WriteLine(holiday);
            //}


            //// and now a for loop
            //for (int i = 0; i < favoriteHolidays.Length; i++)
            //{
            //    Console.WriteLine(favoriteHolidays[i]);
            //}

            //string loops
            int[] multiplesOfThree = { 3, 6, 9, 12, 15, 18 };
            int sum = 0;

            //foreach (int multiple in multiplesOfThree)
            //{
            //    sum += multiple;
            //}

            //for (int i = 0; i < multiplesOfThree.Length; i++)
            //{
            //    sum += multiplesOfThree[i];
            //}

            //Console.WriteLine(sum);

            ////do while
            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great Game!");
            //    Console.WriteLine("Do you want to play again? (Y/N)");
            //    playAgain = Console.ReadLine().ToUpper();               
            //}
            //while(playAgain == "Y");

            int[] nums = { 4, 8, 12, 16, 20 };

            Console.WriteLine(ArraySum(nums));


        }
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
        public static int SumIt(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public static int ArraySum(int[] numbersToBeSummed)
        {
            int sum = 0;
            foreach (int num in numbersToBeSummed)
            {
                sum += num;
            }
            return sum;
        }


    }
}
