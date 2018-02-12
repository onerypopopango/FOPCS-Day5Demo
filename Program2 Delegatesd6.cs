using System;

namespace Day6
{
    class Prog2
    {
        public static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3 };
            PrintArray(A);

            int[] B = Prog2.SquareArray(A);
            PrintArray(B);  //1, 4, 9

            int[] C = Prog2.IncrementArray(A);
            PrintArray(C);  //2, 3, 4

            int[] D = ApplyOperation(A, Square);
            PrintArray(D);  //1, 4, 9
            int[] E = ApplyOperation(A, TimesTen);
            PrintArray(E);  //10, 20, 30
            int[] F = ApplyOperation(A, Sqrt);
            PrintArray(F);  //1, 2, 2

            MickyMouse times100 = delegate (int x) { return x * 100; }; //annoymous method. a method that doesn't belong to a class
            int[] G = ApplyOperation(A, times100);
            PrintArray(G);  //100, 200, 300

            MickyMouse times100b = delegate (int x) { return TimesN(x, 100); };
            int[] H = ApplyOperation(A, times100b);
            PrintArray(H);  //100, 200, 300

            int[] I = ApplyOperation(A, delegate (int x) { return x * 100; });
            PrintArray(I);

            int[] J = ApplyOperation(A, (int x) => { return x * 100; });    //lambda espression. G,H,I and J are the same.
            PrintArray(J);

        }

        //functions that will be used as delegate operations
        static int Square(int x) { return x * x; }
        static int Increment(int x) { return x + 1; }
        static int TimesTen(int x) { return x * 10; }

        static int TimesN(int x, int n) { return x * n; }   //note: not a MickeyMouse

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
        static int[] SquareArray(int[] z)
        {
            int[] numArray = new int[z.Length];
            for (int i = 0; i < z.Length; i++)
            {
                numArray[i] = (z[i] * z[i]);
            }

            return numArray;
        }

        //this method will increment each element of the array
        static int[] IncrementArray(int[] z)
        {
            int[] numArray = new int[z.Length];
            for (int i = 0; i < z.Length; i++)
            {
                numArray[i] = z[i] + 1;
            }

            return numArray;
        }

        static void PrintArray(int[] A)
        {
            Console.WriteLine(string.Join(", ", A));
        }
    }
}
