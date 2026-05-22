public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var map = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++)
        {
            var needed = target - numbers[i];  
            if(map.ContainsKey(needed))
            {
                if(map[needed] < i && needed != numbers[i])
                    return [map[needed] + 1, i + 1];
            }

            map[numbers[i]] = i;

        }   
         
        return [];
    }
}
