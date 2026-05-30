public class Solution {
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        var sum = 0;

        for(int i = 0; i < operations.Length; i++)
        {
            var c = operations[i];

            if(int.TryParse(c, out int number))
                stack.Push(number);
            else if(c == "+")
            {
                var cur = stack.Pop();
                var prev =  stack.Peek();
                stack.Push(cur);
                stack.Push(prev + cur);
            }
            else if(c == "D")
            {
                stack.Push(stack.Peek() * 2);
            }
            else if(c == "C")
            {
                stack.Pop();
            }
        }

        foreach(var rec in stack)
            sum+= rec;

        return sum;
    }

}