using System;
public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stk = new Stack<char>();
        StringBuilder sb = new StringBuilder();

        foreach(char letter in s){
            if(stk.Count != 0){
                if(stk.Peek() == letter){
                    stk.Pop();
                    sb.Remove(sb.Length - 1, 1);
                    continue;
                }
            }
                stk.Push(letter);
                sb.Append(letter);
        }

        return sb.ToString();
    }
}
