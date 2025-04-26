public class Solution {
    public bool IsIsomorphic(string s, string t) {
        bool isIsomorphic = true;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        List<int> l = new List<int>();

        for(int i = 0; i <= s.Length - 1; i++){
            if(!dict.ContainsKey(s[i])){
                if(!l.Contains(t[i])){
                    dict[s[i]] = t[i];
                    l.Add(t[i]);
                }
                else{
                    isIsomorphic = false;
                    break;
                }
            }
            else{
                if(dict[s[i]] != t[i]){
                    isIsomorphic = false;
                    break;
                }
            }
        }
        return isIsomorphic;
    }
}
