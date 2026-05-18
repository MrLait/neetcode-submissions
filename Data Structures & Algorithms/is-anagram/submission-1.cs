public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        var charsS = s.ToCharArray();
        var charsT = t.ToCharArray();
        Array.Sort(charsS);
        Array.Sort(charsT);

        return charsS.SequenceEqual(charsT);
    }
}
