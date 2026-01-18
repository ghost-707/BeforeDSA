namespace Phase1_WhileLoop.Problems;

public class Q22
{
    public static void PrintCubesFrom1ToN(int n)
    {
        Console.WriteLine($"{nameof(Q21)}.{nameof(PrintCubesFrom1ToN)}");

        int i = 1;
        List<int> res = [];
        while (i <= n)
        {
            res.Add(i * i * i);
            i++;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
