public class Solution {
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        var sb = new StringBuilder();

        foreach(var c in path + "/")
        {
            if(c == '/')
            {
                var cur = sb.ToString();
                if(cur == "..")
                {
                    if(stack.Count > 0)
                        stack.Pop();
                }
                else if(cur != "" && cur != ".")
                    stack.Push($"{cur}/");
                
                sb = new StringBuilder();
            }
            else
                sb.Append(c);
        }

        sb.Append("/");
        foreach(var s in stack.Reverse())
            sb.Append(s);
        
        sb.Length--;
        return sb.Length > 0 ? sb.ToString() : "/";
    }
}