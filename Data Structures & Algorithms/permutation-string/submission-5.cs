public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;
        var mapFreq = new Dictionary<char, int>();
        var curFreq = new Dictionary<char, int>();
        int left = 0, len = s1.Length;

        foreach(var s in s1)
            mapFreq[s] = mapFreq.GetValueOrDefault(s) + 1;

        for(int right = 0; right < s2.Length; right++)
        {
            char c = s2[right];
            curFreq[c] = curFreq.GetValueOrDefault(c) + 1;

            while(curFreq[c] > mapFreq.GetValueOrDefault(c))
            {
                curFreq[s2[left]]--;
                left++;
            }

            if (right - left + 1 == len)
                return true;
        }

        return false;
    }
}
