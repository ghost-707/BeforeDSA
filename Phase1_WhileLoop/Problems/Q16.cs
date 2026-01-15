namespace Phase1_WhileLoop.Problems;

public class Q16
{
    public static void CheckPerfectNumber(int n)
    {
        Console.WriteLine($"{nameof(Q16)}.{nameof(CheckPerfectNumber)}");

        List<int> divisors = [];
        int i = 1;

        while (i <= n/2)
        {
            if(n % i == 0)
                divisors.Add(i);

            i++;
        }

        if(divisors.Sum() == n)
        {
            Console.WriteLine($"{n} is a perfect number");
        }
        else
        {
            Console.WriteLine($"{n} is not a perfect number");
        }

        Console.WriteLine();
    }
}
