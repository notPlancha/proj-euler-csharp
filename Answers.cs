namespace euler; 

public static class Answers {
    public static long Problem3() { 
        long value = 600851475143;
        for (long i = 2; i < value; i++) {
            while (value % i == 0) {
                value /= i;
                Console.WriteLine(value);
            }
        }
        return value;
    }
    public static (int, int, int) Problem4() {
        (int, int, int) ret = (0,0,0);
        for (int first = 999; first > 99; first--) {
            for (int second = 999; second > 99; second--) {
                int duplicated = second * first;
                if (ret.Item1 < duplicated && Palindromic.isPalindromic(duplicated)) {
                    ret = (second * first, first, second);
                }
            }
        }
        return ret;
    }
    public static long Problem5() {
        IEnumerable<long> primes = new Prime().YieldPrimes();
        return primes.ElementAt(10001);
    }
    public static (int, int, int) Problem6(){
        
    }
}