using System;

namespace Day5
{
    class Prog4Day6
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine(Multiply(x, y));      //12

            Swap(ref x, ref y);
            Console.WriteLine("{0}, {1}", x, y);    //3, 4. No swap if not passed by reference, i.e. pass by value
        }

        static void Swap(ref int a, ref int b)     //pass by reference
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Multiply(int a, int b)           //pass by value
        {
            //int a = x, int b = y;
            return a * b;
        }
    }
}
