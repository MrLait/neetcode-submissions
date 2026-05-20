public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>();
        var sb = new StringBuilder();

        foreach(var str in strs)
        {
            var sortedChars = str.ToCharArray();
            Array.Sort(sortedChars);

            foreach(var c in sortedChars)
                sb.Append(c);

            dict.TryGetValue(sb.ToString(), out List<string> curValues);

            if(curValues == null)
                curValues = new List<string>();
            curValues.Add(str);
            
            dict[sb.ToString()] = curValues;

            sb = new StringBuilder();
        }

        return dict.Values.ToList();
    }
}
