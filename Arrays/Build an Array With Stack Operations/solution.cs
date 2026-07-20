public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        int index = 0;
        List<string> retList = new List<string>();
        int counter = 0;

        for(int i = 1; i <= n; i++){
            retList.Add("Push"); 
            if(target[index] != i){
                retList.Add("Pop"); 
            }
            else{
                index++; counter++;
            }
            if(counter == target.Length) break;
        }
        return retList;
    }
}
