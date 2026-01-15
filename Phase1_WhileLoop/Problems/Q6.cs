namespace Phase1_WhileLoop.Problems;

public class Q6
{
    public static void SumOfFirstNNaturalNumbers(int n)
    {
        Console.WriteLine($"{nameof(Q6)}.{nameof(SumOfFirstNNaturalNumbers)}");

        int i = 1, sum = 0;
        while (i <= n)
        {
            sum += i;
            i++;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
}