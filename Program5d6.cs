using System;

namespace Day5
{
    class Prog5Day6
    {
        static void Main(string[] args)
        {
            int[] X = { 1, 2, 3 };          //initialising array X without new int[i,j]
            Prog2EditDay6.PrintArray(X);    //1, 2 ,3

            TimesTen(X);
            Prog2EditDay6.PrintArray(X);    //10, 20 ,30

            //Console.WriteLine(Prog4Day6.Multiply(X[1], (X[2])));    //600

            DoubleTheSize(ref X);
            //Console.WriteLine(X.Length);    //3. Why not 6? Cause not passed through reference. <= before passing ref
            Console.WriteLine(X.Length);      //6

            X = DoubleTheSizeNum(X);
            Console.WriteLine(X.Length);

            int[] Y;        //with out, no need to initialise here
            Whatever(out Y); 
        }

        static void Whatever(out int[] A)
        {
            A = new int[1]; //by definition, A needs to be initialised here to give an output
        }

        static int[] DoubleTheSizeNum(int[] A)  
        {
            int[] B = new int[A.Length * 2];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            return B;
        }

        //static void DoubleTheSize(int[] A)  //pass by method
        static void DoubleTheSize(ref int[] A)  //pass by reference
        {
            int[] B = new int[A.Length * 2];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }

            A = B;      //passing a reference datatype by value, will not change the original variable outside the method
        }

        static void TimesTen(int[] A)     //pass by method
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * 10;
            }
        }
    }
}
