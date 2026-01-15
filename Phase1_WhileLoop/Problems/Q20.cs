namespace Phase1_WhileLoop.Problems;

public class Q20
{
    public static void SumFibonacciSeriesTillN(int n)
    {
        Console.WriteLine($"{nameof(Q20)}.{nameof(SumFibonacciSeriesTillN)}");

        int a = 0;
        int b = 1;
        int sum = 0;

        if (n == 1)
            sum += a;
        else if (n == 2)
            sum += b;
        else
        {
            sum = a + b;
            int i = 3;
            while (i <= n)
            {
                int c = a + b;
                sum += c;
                a = b;
                b = c;
                i++;
            }
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}
