public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int total = 0;

        foreach(string operation in operations){
            if(operation == "++X" || operation == "X++") total++;
            else if(operation == "--X" || operation == "X--") total--;
        }

        return total;
    }
}
