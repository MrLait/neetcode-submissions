public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        var result = 0;

        for(int i = 0; i < tokens.Length; i++)
        {
            var isDigit = int.TryParse(tokens[i], out int digit);

            if(isDigit)
            {
                stack.Push(digit);
            }
            else if(!isDigit)
            {
                var numberCur = stack.Pop();
                var numberPrev = stack.Pop();

                if(tokens[i] == "+")
                {
                    result = numberPrev + numberCur;
                    stack.Push(result);
                }
                else if(tokens[i] == "*")
                {
                    result = numberPrev * numberCur;
                    stack.Push(result);
                }
                else if(tokens[i] == "-")
                {
                    result = numberPrev - numberCur;
                    stack.Push(result);
                }
                else if(tokens[i] == "/")
                {
                    result = numberPrev / numberCur;
                    stack.Push(result);
                }
            }
        }

        return stack.Pop();
    }
}
