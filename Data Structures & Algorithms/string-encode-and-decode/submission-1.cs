public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach(var str in strs)
        {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        var result = new List<string>();
        var i = 0;

        while(i < s.Length)
        {
            int j = i;
            while (s[j] != '#') j++;

            int wordLen = int.Parse(s.Substring(i, j - i));
            i = j + 1;

            result.Add(s.Substring(i, wordLen));
            i += wordLen; 
            
        }
        return result;
   }
}