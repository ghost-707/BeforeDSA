namespace Phase1_WhileLoop.Problems;

public static class Q3
{
    public static void PrintEvenNumbers1To100()
    {
        Console.WriteLine($"{nameof(Q3)}.{nameof(PrintEvenNumbers1To100)}");
        
        List<int> res = [];
        int n = 1;

        while (n <= 100)
        {
            if (n % 2 == 0)
                res.Add(n);

            n++;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
