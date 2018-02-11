using System;

namespace Day5
{
    class Prog3
    {
        static void Main(string[] args)
        {
            int x = InputUtility.ReadInteger("Please enter x: ");
            int y = InputUtility.ReadInteger("Please enter y: ");
            int z = InputUtility.ReadInteger();
            Console.WriteLine("You have entered {0}, {1} and {2}.", x, y, z);
        }
    }
}
