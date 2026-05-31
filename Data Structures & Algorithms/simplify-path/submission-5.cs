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
                else if(cur is not "" and not ".")
                    stack.Push($"{cur}");
                
                sb = new StringBuilder();
            }
            else
                sb.Append(c);
        }

        
        return "/" + string.Join('/', stack.Reverse());
    }
}