public class Solution {
    public char RepeatedCharacter(string s) {
        HashSet<char> hashSet = new HashSet<char>();

        foreach(char letter in s){
            if(hashSet.Contains(letter))
                return letter;
            else
                hashSet.Add(letter);
        }
        return 'a';
    }
}
