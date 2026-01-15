namespace Phase1_WhileLoop.Problems;

public class Q9
{
    // won't work for big numbers
    public static void FactorialOfN(int n)
    {
        Console.WriteLine($"{nameof(Q9)}.{nameof(FactorialOfN)}");

        int i = 1;
        long fact = 1;
        while (i <= n)
        {
            fact *= i;
            i++;
        }

        Console.WriteLine(fact);
        Console.WriteLine();
    }
}