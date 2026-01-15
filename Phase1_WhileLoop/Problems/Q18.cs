namespace Phase1_WhileLoop.Problems;

public class Q18
{
    public static void CheckPrime(int n)
    {
        Console.WriteLine($"{nameof(Q18)}.{nameof(CheckPrime)}");

        int divisor = 2;
        bool flag = true;
        while (divisor <= n / 2)
        {
            if (n % divisor == 0)
            {
                flag = false;
                break;
            }
            divisor++;
        }

        if (flag)
        {
            Console.WriteLine($"{n} is prime number");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number");
        }
        Console.WriteLine();
    }
}
