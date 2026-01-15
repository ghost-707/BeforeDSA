namespace Phase1_WhileLoop.Problems;

public class Q17
{
    public static void PrintPrimes1To100()
    {
        Console.WriteLine($"{nameof(Q17)}.{nameof(PrintPrimes1To100)}");
        int i = 1;

        List<int> primes = [];

        while(i <= 100)
        {
            int divisor = 2;
            bool flag = true;
            while(divisor <= i / 2)
            {
                if(i % divisor == 0)
                {
                    flag = false;
                    break;
                }
                divisor++;
            }

            if (flag)
            {
                primes.Add(i);
            }

            i++;
        }

        Console.WriteLine(string.Join(", ", primes));
        Console.WriteLine();
    }
}
