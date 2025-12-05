// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OddEvenNumbers
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintNumbers("Numbers", numbers);
            PrintNumbers("Even No", numbers.Where(i => IsEven(i)));
            PrintNumbers("Odd No", numbers.Where(i => IsOdd(i)));



        }


        static void PrintNumbers(string title, IEnumerable<int> numbers)
        {

            Console.WriteLine();

            Console.Write($"{title}: [");


            foreach (int number in numbers)
            {
                Console.Write($"{number}");
            }

            Console.Write($"]");


            Console.WriteLine();


        }

        static bool IsEven(int number)
        {
            if ( number % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        static bool IsOdd(int number)
        {
            return !IsEven(number);
        }

    }




}