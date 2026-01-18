namespace Phase1_WhileLoop.Problems;

public class Q21
{
    public static void PrintSquaresFrom1ToN(int n)
    {
        Console.WriteLine($"{nameof(Q21)}.{nameof(PrintSquaresFrom1ToN)}");

        int i = 1;
        List<int> res = [];
        while (i <= n)
        {
            res.Add(i * i);
            i++;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
