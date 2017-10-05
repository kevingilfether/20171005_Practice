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
            foreach (string holiday in favoriteHolidays)
            {
                Console.WriteLine(holiday);
            }


            // and now a for loop
            for (int i = 0; i < favoriteHolidays.Length; i++)
            {
                Console.WriteLine(favoriteHolidays[i]);
            }


        }
    }
}
