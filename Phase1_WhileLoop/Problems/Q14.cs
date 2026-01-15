namespace Phase1_WhileLoop.Problems;

public class Q14
{
    public static void SumOfDigits(int n)
    {
        Console.WriteLine($"{nameof(Q14)}.{nameof(SumOfDigits)}");

        int sum = 0;

        while (n != 0)
        {
            int d = n % 10;
            sum += d;
            n /= 10;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}
