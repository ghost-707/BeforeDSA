namespace Phase1_WhileLoop.Problems;

public class Q7
{
    public static void SumOfEvenNumbers1ToN(int n)
    {
        Console.WriteLine($"{nameof(Q7)}.{nameof(SumOfEvenNumbers1ToN)}");

        int i = 1, sum = 0;
        while (i <= n)
        {
            if(i % 2 == 0)
                sum += i;
            i++;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}
