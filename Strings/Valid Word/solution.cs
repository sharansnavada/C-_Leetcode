public class Solution {
    public bool IsValid(string word) {
        bool hasVowel = false;
        bool hasConsonant = false;

        string vowels = "AEIOUaeiou";
        string characters = @"!@#$%^&*()_+-=~`|\}]{[:;'?/>.<,""'";

        foreach(char letter in word){
            if(characters.Contains(letter))
                return false;
            if(vowels.Contains(letter))
                hasVowel = true;
            else if(!char.IsDigit(letter))
                hasConsonant = true;
        }

        return hasVowel && hasConsonant && word.Length > 2;

    }
}
