public class Solution {
    public bool ValidPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        
        if(IsPalindrome(ref i, ref j, s)) return true;
        int i1 = i + 1, j2 = j - 1;
        
        return IsPalindrome(ref i1, ref j, s) || IsPalindrome(ref i, ref j2, s);
    }

    private bool IsPalindrome(ref int i, ref int j, string s)
    {
        while(i <= j)
        {
            if(s[i] != s[j]) return false;
            j--;
            i++;
        }

        return true;
    }
}