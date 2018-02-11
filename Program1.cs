using System;

namespace Day5
{
    class Prog1
    {
        static void Main(string[] args)
        {
            int[,] A = InitializeArray();
            int userInput = GetInput();             //stores output to a variable
            int count = CountInteger(userInput);    //ditto
            PrintOutput(count, userInput);
        }

        static int[,] theArray;                     //declares an array outside of the methods

        static int[,] InitializeArray()
        {
            theArray = new int[,]
           {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7},
            };

            return theArray;

        }

        static int GetInput()
        {
            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static int CountInteger(int integerToFind)
        {
            int b, c = 0;

            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    b = theArray[i, j];

                    if (b == integerToFind)
                    {
                        c++;
                    }
                }
            }
            return c;
        }

        static void PrintOutput (int count, int integerToFind)
        {
            if (count > 0)
            {
                Console.WriteLine("The number of {0} is {1}.", integerToFind, count);
            }

            else
            {
                Console.WriteLine("There is no {0} in the array.", integerToFind);
            }
        }
    }
}
