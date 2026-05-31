public class Solution {
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        foreach(var asteroid in asteroids)
        {
            if(asteroid > 0 || stack.Count == 0 || stack.Peek() < 0)
            {
                stack.Push(asteroid);
                continue;
            }

            var asteroidAbs = -asteroid;
            var isAlive = true;

            while(stack.Count > 0 && stack.Peek() > 0)
            {
                var prev = stack.Peek();

                if(prev == asteroidAbs)
                    stack.Pop();
                else if(prev < asteroidAbs)
                {
                    stack.Pop();
                    continue;                    
                }

                isAlive = false;
                break;
            }

            if(isAlive)
                stack.Push(asteroid);
        }

        var result = new int[stack.Count];

        for(int i = result.Length - 1; i >= 0; i--)
            result[i] = stack.Pop();
        
        return result;
    }
}