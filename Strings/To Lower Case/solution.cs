//optimized code
public class Solution {
    public string ToLowerCase(string s) {
        char []str = s.ToCharArray();
  for(int i=0;i<s.Length;i++)
  {
    if(str[i]>=65&&str[i]<=90)
    str[i]=(char)((int)str[i]+32);
  }
  return new string(str);
    }
}

//My code
public class Solution {
    public string ToLowerCase(string s) {
        string word = "";

        foreach(char c in s){
            word += char.ToLower(c);
        }

        return word;
    }
}
