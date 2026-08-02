public class Solution {
    public bool StoneGame(int[] piles) {
        int alicePoints = 0;
        int bobPoints = 0;
        int start = 0;
        int end = piles.Length - 1;
        bool aliceChance = true;
        bool bobChance = false;

        while(start < end){
            if(aliceChance){
                aliceChance = !aliceChance;
                bobChance = !bobChance;
                if(piles[start] >= piles[end]) alicePoints += piles[start++];
                else alicePoints += piles[end--];
            }
            else{
                aliceChance = !aliceChance;
                bobChance = !bobChance;
                if(piles[start] < piles[end]) bobPoints+= piles[start++];
                else bobPoints += piles[end--];
            }
        }
        return alicePoints > bobPoints;
    }
}
