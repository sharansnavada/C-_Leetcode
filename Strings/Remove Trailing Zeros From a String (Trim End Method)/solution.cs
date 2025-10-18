public class Solution {
    public string RemoveTrailingZeros(string num) {
        return num.TrimEnd('0'); //if you want to delete some character in the start, use num.TrimStart()
    }
}
