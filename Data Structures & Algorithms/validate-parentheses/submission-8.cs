public class Solution {
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        var map = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (var c in s)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0 || stack.Pop() != map[c])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}