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

            dict.TryGetValue(sb.ToString(), out List<string> values);

            if (values == null)
                dict[sb.ToString()] = values = new List<string>();
                
            values.Add(str);

            sb = new StringBuilder();
        }

        return dict.Values.ToList();
    }
}
