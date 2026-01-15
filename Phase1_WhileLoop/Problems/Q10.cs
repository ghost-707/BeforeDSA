namespace Phase1_WhileLoop.Problems;

public class Q10
{
    // won't work for big numbers
    public static void ProductOfAllDigits(int n)
    {
        Console.WriteLine($"{nameof(Q10)}.{nameof(ProductOfAllDigits)}");

        long prod = 1;
        while (n != 0)
        {
            int d = n % 10;
            prod *= d;
            n /= 10;
        }

        Console.WriteLine(prod);
        Console.WriteLine();
    }
}