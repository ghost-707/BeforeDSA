namespace Phase1_WhileLoop.Problems;

public class Q15
{
    public static void CheckArmstrongNumber(int n)
    {
        Console.WriteLine($"{nameof(Q15)}.{nameof(CheckArmstrongNumber)}");

        int digitsCount = 0;
        int x = n;
        while (x != 0)
        {
            digitsCount++;
            x /= 10;
        }

        x = n;
        int sum = 0;
        while(x != 0)
        {
            int d = x % 10;
            sum += (int)Math.Pow(d, digitsCount);
            x /= 10;
        }

        if(n == sum)
        {
            Console.WriteLine($"{n} is an armstrong number");
        }
        else
        {
            Console.WriteLine($"{n} is not an armstrong number");
        }

        Console.WriteLine();
    }
}
