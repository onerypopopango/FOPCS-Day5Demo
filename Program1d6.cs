using System;

namespace Day6
{
    class Prog1
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3 };
            PrintArray(A);

            int[] B =Prog1.SquareArray(A);
            PrintArray(B);  //1, 4, 9

            int[] C = Prog1.IncrementArray(A);
            PrintArray(C);  //2, 3, 4

            int[] D = ApplyOperation(A, Square);
            PrintArray(D);  //1, 4, 9
            int[] E = ApplyOperation(A, TimesTen);
            PrintArray(E);  //10, 20, 30
            int[] F = ApplyOperation(A, Sqrt);
            PrintArray(F);  //1, 2, 2
        }

        //functions that will be used as delegate operations
        static int Square(int x) { return x * x; }
        static int Increment(int x) { return x + 1; }
        static int TimesTen(int x) { return x * 10; }
        static double Sqrt(double x) { return Math.Sqrt(x); }      //this double will return an error if delegate 
                                                                   //  MickeyMouse is used, i.e. not a MickeyMouse
        static int Sqrt(int x) { return (int)Math.Round(Math.Sqrt(x)); }    //overloaded function
                                                                 
        delegate int MickyMouse(int b);     //delegate; this one takes in integer and returns int

        static int[] ApplyOperation(int[] A, MickyMouse ops)
        {
            int[] newArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = ops(A[i]);        //applying ops to each element
            }
            return newArray;
        }

        //this method will perform square operaions for each element of the array
        static int[] SquareArray(int[] A)
        {
            int[] numArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                numArray[i] = A[i] * A[i];
            }

            return A;
        }

        //this method will increment each element of the array
        static int[] IncrementArray(int[] A)
        {
            int[] numArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                numArray[i] = A[i]++;
            }

            return A;
        }

        static void PrintArray(int[] A)
        {
            Console.WriteLine(string.Join(", ", A));
        }
    }
}
