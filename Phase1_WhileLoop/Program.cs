using Phase1_WhileLoop.Problems;

namespace Phase1_WhileLoop;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 23;

        Q1.Print1To10();
        Q2.Print10To1();
        Q3.PrintEvenNumbers1To100();
        Q4.PrintOddNumbers1To100();
        Q5.PrintTableOfN(n);
        Q6.SumOfFirstNNaturalNumbers(n);
        Q7.SumOfEvenNumbers1ToN(n);
        Q8.SumOfOddNumbers1ToN(n);
        Q9.FactorialOfN(n);

        n = 1213121;
        Q10.ProductOfAllDigits(n);
        Q11.CountTotalNumberOfDigits(n);
        Q12.ReverseNumber(n);
        Q13.CheckPalindrome(n);
        Q14.SumOfDigits(n);
        Q15.CheckArmstrongNumber(153);
        Q16.CheckPerfectNumber(6);
        Q17.PrintPrimes1To100();
        Q18.CheckPrime(n);
        Q19.PrintFibonacciSeriesTillN(13);
        Q20.SumFibonacciSeriesTillN(13);

    }
}
