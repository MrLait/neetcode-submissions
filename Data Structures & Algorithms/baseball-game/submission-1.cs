public class Solution {
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        var total = 0;

        foreach(var op in operations)
        {
            if(int.TryParse(op, out int number))
                stack.Push(number);
            else if(op == "+")
            {
                var cur = stack.Pop();
                var prev =  stack.Peek();
                stack.Push(cur);
                stack.Push(prev + cur);
            }
            else if(op == "D")
                stack.Push(stack.Peek() * 2);
            else if(op == "C")
                stack.Pop();
        }

        foreach(var rec in stack)
            total+= rec;

        return total;
    }
}