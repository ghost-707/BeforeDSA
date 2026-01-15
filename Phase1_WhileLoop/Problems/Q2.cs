namespace Phase1_WhileLoop.Problems;

public class Q2
{
    public static void Print10To1()
    {
        Console.WriteLine($"{nameof(Q2)}.{nameof(Print10To1)}");
        
        List<int> res = [];
        int n = 10;

        while (n >= 1)
        {
            res.Add(n);
            n--;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}
