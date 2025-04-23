public class Solution {
    public int StrStr(string haystack, string needle) {
        char[] arr = haystack.ToCharArray();
        int start = 0;int end = needle.Length - 1;
        bool allSame = false;
        while(end <= arr.Length - 1){
            int k = 0;
            for(int i = start; i <= end ; i++){
                if(arr[i] != needle[k]){
                    allSame = false;
                    break;
                }
                else if(arr[i] == needle[k]){
                    k++;
                    allSame = true;
                }
            }
            if(allSame){
                return start;
            }
            start++;end++;
        }
        return -1;
    }
}
