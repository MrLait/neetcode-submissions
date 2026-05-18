public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sMap = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++) {
            sMap.TryGetValue(s[i], out int count);
            sMap[s[i]] = count + 1;

            sMap.TryGetValue(t[i], out count);
            sMap[t[i]] = count - 1;
        }

        
        return sMap.All(x => x.Value == 0);
    }
}
