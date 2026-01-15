namespace Phase1_WhileLoop.Problems;

public class Q5
{
    public static void PrintTableOfN(int n)
    {
        Console.WriteLine($"{nameof(Q5)}.{nameof(PrintTableOfN)}");

        int i = 1;

        while (i <= 10)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
            i++;
        }

        Console.WriteLine();
    }
}
