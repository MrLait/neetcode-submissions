public class Solution {
    public int MinEatingSpeed(int[] piles, int h)
    {
        int mid = 0, l = 1, r = piles.Max();
        int hours = 0, k = r;

        while(l <= r)
        {
            mid = l + (r - l) / 2;   

            hours = GetSpendedHours(piles, mid);
    
            if(hours <= h)
                k = Math.Min(k, mid);

            if(hours <= h)
                r = mid - 1;
            else
                l = mid + 1;
        }

        return k;
    }

    private int GetSpendedHours(int[] piles, int k)
    {
        var h = 0;

        for(int i = 0; i < piles.Length; i++)
        {
            h += (int)Math.Ceiling((double)piles[i] / k);
        }

        return h;
    }
}
