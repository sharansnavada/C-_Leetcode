//Worst structured code ever written by the human race just to pass all test cases.

public class Solution {
    public string RemoveOccurrences(string s, string part) {
        Stack<char> stk = new Stack<char>();

        for(int i = 0; i < s.Length; i++){
            char currLetter = s[i];
            bool falseAlarm = false;
            stk.Push(currLetter);
            if(currLetter == part[part.Length - 1] && stk.Count >= part.Length){
                int partIndex = part.Length - 1;
                StringBuilder sb = new StringBuilder();
                while(partIndex > -1 && stk.Count > 0){
                    char l = stk.Pop();
                    sb.Append(l);
                    if(part[partIndex] != l){
                        falseAlarm = true;
                        break;
                    }
                    partIndex--;
                }
                if(falseAlarm){
                    string strSB = new string(sb.ToString().Reverse().ToArray());
                    for(int j = 0; j < strSB.ToString().Length; j++){
                        stk.Push(strSB.ToString()[j]);
                    }
                }
            }
        }
        StringBuilder sbb = new StringBuilder();
        while(stk.Count != 0)
        {
            sbb.Append(stk.Pop());
        }
        return new string(sbb.ToString().Reverse().ToArray());
    }
}
