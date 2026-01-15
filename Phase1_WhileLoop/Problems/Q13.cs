namespace Phase1_WhileLoop.Problems;

public class Q13
{
    public static void CheckPalindrome(int n)
    {
        Console.WriteLine($"{nameof(Q13)}.{nameof(CheckPalindrome)}");

        int rev = 0;
        int x = n;

        while (x != 0)
        {
            int d = x % 10;
            rev = rev * 10 + d;
            x /= 10;
        }

        if (n == rev)
        {
            Console.WriteLine($"{n} is a palindrome number");
        }
        else
        {
            Console.WriteLine($"{n} is not a palindrome number");
        }

        Console.WriteLine();
    }
}

