public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        int min = int.MinValue;
        string[] retArr = new string[names.Length];
        int n = 0;

        while(n != names.Length){
            int index = 0;
            min = int.MinValue;
            for(int i = 0; i < names.Length; i++){
                if(heights[i] > min){
                    min = heights[i];
                    index = i;
                }
            }
            retArr[n] = names[index];
            heights[index] = int.MinValue;
            n++;
        }
        return retArr;
    }
}
