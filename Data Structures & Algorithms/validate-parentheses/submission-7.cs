public class Solution {
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach(var c in s)
        {

            if(c == '(' || c ==  '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                var isEmpty = stack.TryPop(out char curr);
                
                if(!isEmpty) return false;

                if(curr == '[' && c != ']')
                    return false;
                else if(curr == '{' && c != '}')
                    return false;
                else if(curr == '(' && c != ')')
                    return false;
            }
        }

        return stack.Count == 0; 
    }
}
