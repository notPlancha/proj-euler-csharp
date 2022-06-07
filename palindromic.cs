namespace euler;
public static class Palindromic {
    public static bool isPalindromic(int value) => isPalindromic(value.ToString());

    public static bool isPalindromic(string value) {
        int mid = value.Length / 2;
        if (value.Length % 2 == 0) {
            if (value.Substring(0, mid) == value.Substring(mid, mid).Reverse()) return true;
            return false;
        } else {
            if (value.Substring(0, mid) == value.Substring(mid + 1, mid).Reverse()) return true;
            return false;
        }
    }
    public static string Reverse(this string value) {
        char[] charArray = value.ToCharArray();
        Array.Reverse( charArray );
        return new string(charArray);
    }
}