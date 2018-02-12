using System;

namespace Day6
{
    class Day6Quiz
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmount = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = Day6Quiz.AskForIncome();
            int taxBracket = Day6Quiz.GetTaxBracket(annualIncome);
            double taxPayable = Day6Quiz.CalculateIncomeTax(annualIncome, taxBracket);
            Day6Quiz.PrintResult(annualIncome, taxPayable);
        }

        //my answer below

        static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int num = Int32.Parse(Console.ReadLine());
            return num;
        }

        static int GetTaxBracket(int annualInc)
        {
            int position = 0;

            if (annualInc >= 20000)
            {
                for (int i = 0; i < taxRateArray.Length; i++)
                {
                    if (minIncomeArray[i] < annualInc)
                    {
                        position = i;
                    }
                }
            }

            else { position = -1; }

            return position;
        }

        static double CalculateIncomeTax (int m, int n)
        {
            double incomeTax = 0;

            if (n == -1)
            {
                incomeTax = 0;
            }

            else
            {
                int minInc = minIncomeArray[n];
                double taxRate = taxRateArray[n];
                int baseAmt = basePayableAmount[n];

                incomeTax = ((m - minInc) * taxRate) + baseAmt;
            }

            return incomeTax;
        }

        static void PrintResult(int x, double y)
        {
            Console.WriteLine("For taxable annual income of {0:C}, the tax payable amount is {1:C}", x, y);
        }
    }
}
