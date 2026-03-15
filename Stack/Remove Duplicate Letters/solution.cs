public class Solution {
    public string RemoveDuplicateLetters(string s) {
        Stack<char> stk = new Stack<char>();
        int[] hashTable = new int[26];
        StringBuilder sb = new StringBuilder();

        foreach(char letter in s){
            hashTable[letter - 'a']++; // to keep track of count of particular character in a string.
        }

        foreach(char letter in s)
        {
            // if charater is already present in the stack,
            //  it wont enter into any of the condition and decrement from the hashtable wont happen.
            //  So if decrementHappened is false, then we have to manually do decrement.
            bool decrementHappend = false; 
            if(stk.Count == 0 && !stk.Contains(letter)) // for the 0th character.
            {
                stk.Push(letter);
                sb.Append(letter);
                hashTable[letter - 'a']--;
                decrementHappend = true;
            }
            else if(letter > stk.Peek() && !stk.Contains(letter))
            {
                stk.Push(letter);
                hashTable[letter - 'a']--;
                decrementHappend = true;
                sb.Append(letter);
            }
            else if(letter < stk.Peek() && hashTable[stk.Peek() - 'a'] > 0 && !stk.Contains(letter))
            {
                // if current charater is lower than the peek and if peek is present further in the s,
                //  we can remove now and add it later to acheive lexicographical order.
                while(stk.Peek() > letter && hashTable[stk.Peek() - 'a'] > 0) 
                {
                    stk.Pop();
                    sb.Remove(sb.Length - 1, 1);
                    if(stk.Count == 0) break;
                }
                stk.Push(letter);
                sb.Append(letter);
                hashTable[letter - 'a']--;
                decrementHappend = true;
            }
            else
            {
                if(!stk.Contains(letter))
                {
                    stk.Push(letter); hashTable[letter - 'a']--;
                    decrementHappend = true;
                    sb.Append(letter);
                }
            }
            if(!decrementHappend) hashTable[letter - 'a']--;
        }
        return sb.ToString();
    }
}
