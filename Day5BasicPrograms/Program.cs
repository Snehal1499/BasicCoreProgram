﻿using System;

namespace Day5BasicPrograms
{
    internal class Program
    {
        public class Even_Or_Odd
        {
            public void EvenOrOdd(int number)
            {

                if (number % 2 == 0)
                {
                    Console.WriteLine($"Given Number {number} is Even");

                }
                else
                {
                    Console.WriteLine($"Given Number {number} is Odd");
                }
            }

        }
        internal class Programs
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Numbers ");
                int number = Convert.ToInt32(Console.ReadLine());
                Even_Or_Odd eo = new Even_Or_Odd();
                eo.EvenOrOdd(number);

            }
        }
    }
}

