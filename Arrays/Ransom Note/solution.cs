public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] letters = new int[26];
        foreach(char c in magazine)
            letters[c - 'a']++;
        foreach(char ch in ransomNote){
            letters[ch - 'a']--;
            if(letters[ch - 'a'] == -1)
                return false;
        }
        return true;
    }
}

// My code
// public class Solution {
//     public bool CanConstruct(string ransomNote, string magazine) {
//          Dictionary<char, int> dict = new Dictionary<char, int>();

//         foreach (char letter in magazine)
//         {
//             if (dict.ContainsKey(letter))
//             {
//                 dict[letter] += 1;
//             }
//             else
//             {
//                 dict[letter] = 1;
//             }
//         }

//         foreach (char letter in ransomNote)
//         {
//             if (dict.ContainsKey(letter))
//             {
//                 if (dict[letter] > 0)
//                 {
//                     dict[letter] -= 1;
//                 }
//                 else
//                 {
//                     return false;
//                 }
//             }
//             else
//             {
//                 return false;
//             }
//         }
//         return true;
//     }
// }
