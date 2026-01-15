namespace Phase1_WhileLoop.Problems;

public class Q11
{
    public static void CountTotalNumberOfDigits(int n)
    {
        Console.WriteLine($"{nameof(Q11)}.{nameof(CountTotalNumberOfDigits)}");

        int count = 0;
        while (n != 0)
        {
            count++;
            n /= 10;
        }

        Console.WriteLine(count);
        Console.WriteLine();
    }
}