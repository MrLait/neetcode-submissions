public class Solution {
    public bool IsPalindrome(string s) {
        var j = s.Length - 1;
        var i = 0;

        while(i < j)
        {    
            while (!char.IsLetterOrDigit(s[i]) && i < j)
            {
                i++;
            }
            
            while (!char.IsLetter(s[j]) && j > i) 
            {
                j--;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            Console.WriteLine(s[i]);
            Console.WriteLine(s[j]);
            
            i++;
            j--;
        }

        return true;
    }
}
