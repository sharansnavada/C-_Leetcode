public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int[] dupCandies = candies.ToArray();
        Array.Sort(dupCandies);
        bool[] retArray = new bool[candies.Length];
        int counter = 0;
        foreach(int candy in candies){
            if((candy + extraCandies) >= dupCandies[candies.Length - 1]){
                retArray[counter++] = true;
            }
            else{
                retArray[counter++] = false;
            }
        }
        return retArray;
    }
}
