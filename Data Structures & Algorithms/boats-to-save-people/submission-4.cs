public class Solution {
    public int NumRescueBoats(int[] people, int limit)
    {
        int boatCnt = 0, l = 0, r = people.Length - 1;
        Array.Sort(people);

        while(l <= r)
        {
            if(people[l] <= limit - people[r])
                l++;

            r--;
            boatCnt++;
        }

        return boatCnt;    
    }
}