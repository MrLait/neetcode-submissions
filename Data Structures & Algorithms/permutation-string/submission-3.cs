public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if(s1.Length > s2.Length) return false;
        var mapFreq = new Dictionary<char, int>();
        var curFreq = new Dictionary<char, int>();
        int left = 0, len = s1.Length, curLen = 0;

        foreach(var s in s1)
            mapFreq[s] = mapFreq.GetValueOrDefault(s) + 1;

        for(int right = 0; right < s2.Length; right++)
        {
            char c = s2[right];

            if(!mapFreq.ContainsKey(c))
            {
                curFreq = new Dictionary<char, int>();
                curLen = 0;
                left = right + 1;
            }
            else
            {
                curFreq[c] = curFreq.GetValueOrDefault(c) + 1;

                if(curFreq[c] > mapFreq[c])
                {
                    left++;                       
                    right = left - 1;             
                    curFreq = new Dictionary<char, int>();
                    curLen = 0;
                    continue;
                }
                    curLen++;
            }

                if(curLen == len)
                    return true;

        }

        return false;
    }
}
