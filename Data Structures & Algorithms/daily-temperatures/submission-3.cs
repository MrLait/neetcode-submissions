public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var days = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int curDay = 0; curDay < temperatures.Length; curDay++)
        {
            while(days.Count != 0 && temperatures[days.Peek()] < temperatures[curDay])
            {
                var day = days.Pop();
                result[day] = curDay - day;
            }

            days.Push(curDay);
        }

        return result;
    }
}
