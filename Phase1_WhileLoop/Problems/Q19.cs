namespace Phase1_WhileLoop.Problems;

public class Q19
{
    public static void PrintFibonacciSeriesTillN(int n)
    {
        Console.WriteLine($"{nameof(Q19)}.{nameof(PrintFibonacciSeriesTillN)}");

        int a = 0;
        int b = 1;
        List<int> res = [];

        if (n == 1)
            res.Add(a);
        else if (n == 2)
            res.Add(b);
        else
        {
            res.Add(a);
            res.Add(b);
            int i = 3;
            while (i <= n)
            {
                int c = a + b;
                res.Add(c);
                a = b;
                b = c;
                i++;
            }
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
