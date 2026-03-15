public class Solution {
    public string RemoveDuplicateLetters(string s) {
        Stack<char> stk = new Stack<char>();
        int[] hashTable = new int[26];
        StringBuilder sb = new StringBuilder();
        //char lastLetter = '1';

        foreach(char letter in s){
            hashTable[letter - 'a']++;
        }

        foreach(char letter in s)
        {
            //if(lastLetter == letter) hashTable[letter - 'a']--;
            bool decrementHappend = false;
            /*else*/ if(stk.Count == 0 && !stk.Contains(letter))
            {
                stk.Push(letter);
                sb.Append(letter);
                hashTable[letter - 'a']--;
                decrementHappend = true;
            }
            else if(letter > stk.Peek() && !stk.Contains(letter)/*&& hashTable[letter - 'a'] != -1*/)
            {
                stk.Push(letter);
                hashTable[letter - 'a']--;
                decrementHappend = true;
                //hashTable[letter - 'a'] = -1;
                sb.Append(letter);
            }
            else if(letter < stk.Peek() && hashTable[stk.Peek() - 'a'] > 0 && !stk.Contains(letter)/*&& hashTable[letter - 'a'] != -1*/)
            {
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
                //if(hashTable[letter - 'a'] != -1)
                if(!stk.Contains(letter))
                {
                    stk.Push(letter); hashTable[letter - 'a']--;
                    decrementHappend = true;
                    sb.Append(letter);
                }
            }
            //lastLetter = letter;
            if(!decrementHappend) hashTable[letter - 'a']--;
        }
        return sb.ToString();
    }
}
