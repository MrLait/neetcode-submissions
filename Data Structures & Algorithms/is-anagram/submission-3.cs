public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++) {
            map[s[i]] = map.GetValueOrDefault(s[i]) + 1;
            map[t[i]] = map.GetValueOrDefault(t[i]) - 1;
        }

        return map.All(x => x.Value == 0);
    }
}
