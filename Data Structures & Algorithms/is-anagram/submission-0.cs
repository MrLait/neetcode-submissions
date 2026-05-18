public class Solution {
    public bool IsAnagram(string s, string t)
    {
        var sbS = new StringBuilder();
        var sbT = new StringBuilder();
        
        if(s.Length != t.Length)
            return false;

        var charsS = s.ToCharArray();
        var charsT = t.ToCharArray();
        Array.Sort(charsS);
        Array.Sort(charsT);
        sbS.Append(charsS);
        sbT.Append(charsT);

        return sbS.ToString() == sbT.ToString();
    }
}
