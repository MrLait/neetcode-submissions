public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach(var token in tokens)
        {
            if(int.TryParse(token, out int num))
                stack.Push(num);
            else
            {
                var a = stack.Pop();
                var b = stack.Pop();

                int result = token switch
                {
                    "+" => a + b,
                    "-" => b - a,
                    "*" => a * b,
                    "/" => b / a
                };
                
                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
