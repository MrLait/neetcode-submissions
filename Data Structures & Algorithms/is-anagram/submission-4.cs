public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var map = new Dictionary<char, int>(26);

        for (var i = 0; i < s.Length; i++) {
            map.TryGetValue(s[i], out int countS);
            map[s[i]] = countS + 1;

            map.TryGetValue(t[i], out  countS);
            map[t[i]] = countS - 1;
        }

        return map.Values.All(v => v == 0);
    }
}
