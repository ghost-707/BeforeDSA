namespace Phase1_WhileLoop.Problems;

public class Q12
{
    public static void ReverseNumber(int n)
    {
        Console.WriteLine($"{nameof(Q12)}.{nameof(ReverseNumber)}");

        int rev = 0;

        while (n != 0)
        {
            int d = n % 10;
            rev = rev * 10 + d;
            n /= 10;
        }

        Console.WriteLine(rev);
        Console.WriteLine();
    }
}