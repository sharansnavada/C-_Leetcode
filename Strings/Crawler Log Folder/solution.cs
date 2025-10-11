public class Solution {
    public int MinOperations(string[] logs) {
        int count = 0;

        foreach(string log in logs){
            if(log == "../"){
                if(count != 0) //if we decrement for negative, it will effect the calculations for the futur count aswell
                    count--;
            }
            else if(log == "./") //do nothing as we remaining in the same folder
                continue;
            else
                count++;
        }
        // if(count < 0)
        //     return 0;
        return count;
    }
}
