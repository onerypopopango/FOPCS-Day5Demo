using System;

namespace Day5
{
    class InputUtility
    {
        public static int ReadInteger(string prompt)
        {
            bool isParseDone;
            int userInput;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isParseDone = Int32.TryParse(input, out userInput);

                if (isParseDone == false)
                {
                    Console.WriteLine("You are a dummy. That's not a number!\n");
                }
            }
            while (isParseDone == false);

            return userInput;
        }

        public static int ReadInteger()
        {
            return ReadInteger("Please enter an integer: ");

            //int x = ReadReadInteger("Please enter an integer: ");
            //return x;
        }
    }
}
