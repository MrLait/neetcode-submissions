public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        var freq = new Dictionary<char, int>();
        int maxLen = 0, left = 0, maxFreq = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            freq[c] = freq.GetValueOrDefault(c) + 1;
            maxFreq = Math.Max(maxFreq, freq[c]);

            if((right - left + 1) - maxFreq > k)
            {
                freq[s[left]]--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }
        return maxLen;
    }
}
