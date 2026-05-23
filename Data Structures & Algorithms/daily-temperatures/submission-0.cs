public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var stack = new Stack<int[]>();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stack.Count != 0 && stack.Peek()[0] < temperatures[i])
            {
                if(stack.TryPop(out int[] num));
                    result[num[1]] = i - num[1];
            }

            stack.Push([temperatures[i], i]);
        }

        return result;
    }
}
