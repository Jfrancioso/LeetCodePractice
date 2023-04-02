/*PrimeFactors: Create an integer array method called PrimeFactors that takes in an integer "n" and returns an integer array of the prime factors of the number. The input will be greater than 1.*/


public static List<int> GetPrimeFactors(int n)
    {
        List<int> factors = new List<int>();

        // Divide by 2 until n is odd
        while (n % 2 == 0)
        {
            factors.Add(2);
            n /= 2;
        }

        // Divide by odd numbers starting from 3
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            while (n % i == 0)
            {
                factors.Add(i);
                n /= i;
            }
        }

        // If n is a prime number greater than 2
        if (n > 2)
        {
            factors.Add(n);
        }

        return factors;
    }