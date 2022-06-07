namespace euler; 

public class Prime {
    private List<long> calculatedPrimes = new();

    public IEnumerable<long> YieldPrimes() {
        yield return 2;
        int i = 3;
        while (true) {
            yield return i;
            do {
                i += 2;
            } while (!isPrime(i));
        }
    }
    
    public bool isPrime(long value) {
        //calculates if numebr is prime based on previous calculated primes
        foreach (long i in calculatedPrimes) {
            if (i > value) break;
            if (value % i == 0) return false;
        }
        calculatedPrimes.Add(value);
        return true;
    }
}