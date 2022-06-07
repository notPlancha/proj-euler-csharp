using System.Text;

namespace euler; 

public static class Extensions {
    public static string Reverse(this string value) {
        char[] charArray = value.ToCharArray();
        Array.Reverse( charArray );
        return new string(charArray);
    }
    
    public static string ReplaceOnIndex(this string value, int index, string newString) {
        throw new NotImplementedException();
    }

    public static string RemoveOnIndexes(this string value, int[] indexes) {
        StringBuilder ret = new StringBuilder(value);
        foreach (var i in indexes) {
            ret[i] = '✎';
        }

        return ret.ToString().Replace("✎", "");
    }
    
}