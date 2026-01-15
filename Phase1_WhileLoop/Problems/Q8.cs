namespace Phase1_WhileLoop.Problems;

public class Q8
{
    public static void SumOfOddNumbers1ToN(int n)
    {
        Console.WriteLine($"{nameof(Q8)}.{nameof(SumOfOddNumbers1ToN)}");

        int i = 1, sum = 0;
        while (i <= n)
        {
            if (i % 2 != 0)
                sum += i;
            i++;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}