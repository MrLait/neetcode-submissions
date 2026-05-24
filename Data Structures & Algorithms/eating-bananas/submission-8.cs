public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int mid = 0, l = 1, r = piles.Max();
        long hours = 0;

        while(l < r)
        {
            mid = l + (r - l) / 2;   
            hours = GetSpendedHours(piles, mid);
    
            if(hours <= h)
                r = mid;
            else
                l = mid + 1;
        }

        return l;
    }

    private long GetSpendedHours(int[] piles, int k)
    {
        long h = 0;

        foreach(var pile in piles)
            h += (pile + k - 1) / k;

        return h;
    }
}
