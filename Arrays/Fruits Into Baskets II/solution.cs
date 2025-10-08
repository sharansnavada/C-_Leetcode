public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int count = 0;

        foreach(int fruit in fruits){
            bool filled = false;
            int index = 0;
            foreach(int basket in baskets){
                if(basket >= fruit){
                    filled = true;
                    baskets[index] = -1; // as this basket is filled with one type
                    break;
                }
                index++;
            }
            if(!filled)
                count++;
        }
        return count;
    }
}
