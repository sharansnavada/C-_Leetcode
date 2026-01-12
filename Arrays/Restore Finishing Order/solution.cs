public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        int[] retArr = new int[friends.Length];
        int index = 0;

        foreach(int ord in order){
            foreach(int friend in friends){
                if(friend == ord){
                    retArr[index] = friend;
                    index++;
                }
            }
        }
        return retArr;
    }
}
