namespace Phase1_WhileLoop.Problems;

public class Q4
{
    public static void PrintOddNumbers1To100()
    {
        Console.WriteLine($"{nameof(Q4)}.{nameof(PrintOddNumbers1To100)}");
        List<int> res = [];

        int n = 1;
        while (n <= 100)
        {
            if (n % 2 != 0)
                res.Add(n);

            n++;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
