﻿using System;

namespace Day5
{
    class Day5Quiz
    {
        public static void Main(string[] args)
        {
            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7},
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            int b;

            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    b = theArray[i, j];

                    if (b == input)
                    {
                        count++;
                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine("The number of {0} is {1}.", input, count);
            }

            else
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
        }
    }
}
