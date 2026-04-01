public class Solution {
    public int CalPoints(string[] operations) {
        Stack<string> stk = new Stack<string>();
        int sum = 0;

        foreach(string s in operations){
            if(s == "C") stk.Pop();
            else if(s == "D") stk.Push((int.Parse(stk.Peek()) * 2).ToString());
            else if(s == "+"){
                string peekStr = stk.Peek();
                stk.Pop();
                string secPeekStr = stk.Peek();
                int n = int.Parse(peekStr) + int.Parse(secPeekStr);
                stk.Push(peekStr);
                stk.Push(n.ToString());
            }
            else stk.Push(s);
        }

        while(stk.Count != 0){
            string peekStr = stk.Peek();
            stk.Pop();
            sum += int.Parse(peekStr);
        }

        return sum;
    }
}
