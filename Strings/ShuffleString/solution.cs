public class Solution {
    public string RestoreString(string s, int[] indices) {
        string[] normalStr = new string[indices.Length];
        int indicesPointer = 0;

        while(indicesPointer != indices.Length){
            normalStr[indices[indicesPointer]] = s[indicesPointer].ToString();
            indicesPointer++;
        }

        string result = string.Join("", normalStr);
        return result;

    }
}
