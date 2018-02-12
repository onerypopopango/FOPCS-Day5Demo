using System;

namespace Day5
{
    class Prog2EditDay6
    {
        static void Main(string[] args)
        {
            int[,] myArray = InitializeArray();
            int userInput = GetInput();             //stores output to a variable

            //int count = CountInteger(myArray, userInput);    //ditto  //old

            //PrintOutput(count, userInput);                            //old
            //PrintArray(myArray);                                      //old
                

            Criteria c = delegate (int x) { return x == userInput; };    //new addition
            int count1 = CountByCriteria(c);

            PrintOutput(count1, userInput);
            PrintArray(myArray);
        }

        delegate bool Criteria(int x);                  //new

        static int CountByCriteria(Criteria ops)        //new
        {
            int[,] anArray = InitializeArray();
            int b, c = 0;

            for (int i = 0; i < anArray.GetLength(0); i++)
            {
                for (int j = 0; j < anArray.GetLength(1); j++)
                {
                    b = anArray[i, j];

                    if (ops(anArray[i, j]))             //new criteria here
                    {
                        c++;
                    }
                }
            }
            return c;
        }

        static int[,] InitializeArray()
        {
            Random rnd = new Random();
            int a = rnd.Next(3, 5);
            int b = rnd.Next(3, 5);

            int[,] theArray = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    int c = rnd.Next(0, 9);
                    theArray[i, j] = c;
                    c = 0;
                }
            }
         
            return theArray;

        }

        static int GetInput()
        {
            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static int CountInteger(int[,] anArrary, int integerToFind)
        {
            int b, c = 0;

            for (int i = 0; i < anArrary.GetLength(0); i++)
            {
                for (int j = 0; j < anArrary.GetLength(1); j++)
                {
                    b = anArrary[i, j];

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

        public static void PrintArray (int[,] anArray)
        {
            Console.WriteLine(String.Join(", ", anArray));
        }

        public static void PrintArray(int[] anArray)
        {
            Console.WriteLine(String.Join(", ", anArray));
        }
    }
}
