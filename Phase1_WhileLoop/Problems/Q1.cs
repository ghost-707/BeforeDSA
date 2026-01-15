namespace Phase1_WhileLoop.Problems;

public class Q1
{
    public static void Print1To10()
    {
        Console.WriteLine($"{nameof(Q1)}.{nameof(Print1To10)}");
        
        List<int> res = [];
        int n = 1;
        
        while (n <= 10)
        {
            res.Add(n);
            n++;
        }

        Console.WriteLine(string.Join(", ", res));
        Console.WriteLine();
    }
}