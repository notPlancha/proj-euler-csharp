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
}