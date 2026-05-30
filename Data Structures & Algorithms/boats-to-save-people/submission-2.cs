public class Solution {
    public int NumRescueBoats(int[] people, int limit)
    {
        int boatCnt = 0, l = 0, r = people.Length - 1;
        Array.Sort(people);

        while(l <= r)
        {
            var remainCapacity = limit - people[r];
            r--;
            boatCnt++;

            if(people[l] <= remainCapacity)
                l++;
        }

        return boatCnt;    
    }
}