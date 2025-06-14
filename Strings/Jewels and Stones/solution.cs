public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
         int count = 0;
         List<char> stoness = new List<char>();

         foreach(char stone in jewels){
            if(!stoness.Contains(stone)){
                stoness.Add(stone);
            }
         }

         foreach(char stone in stones){
            if(stoness.Contains(stone)){
                count++;
            }
         }
         return count;
    }
}
