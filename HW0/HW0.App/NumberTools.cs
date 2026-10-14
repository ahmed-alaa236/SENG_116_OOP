

namespace HW0.App;

public static class NumberTools
{
    public static int DigitSum(long number)
    {
        if (number < 0)
        {
            number = -number;
        }

        int sum = 0;

        while (number > 0)
        {
            sum = sum + (int)(number % 10);
            number = number / 10;
        }

        return sum;
    }

    public static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int d = 2; d < n; d++)
        {
            if (n % d == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int CountPrimes(int upperBound)
    {
        int count = 0;

        for (int k = 2; k <= upperBound; k++)
        {
            if (IsPrime(k))
            {
                count++;
            }
        }

        return count;
    }
}
