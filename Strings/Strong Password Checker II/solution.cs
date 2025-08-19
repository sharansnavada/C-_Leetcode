public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        bool hasLower = false, hasUpper = false, hasDigit = false, hasSpecialCharacter = false;
        string specialCharacter = "!@#$%^&*()-+";
        int length = password.Length;
        char prevChar = ' ';

        foreach(char letter in password){
            if(!hasUpper || !hasLower || !hasDigit || !hasSpecialCharacter){ // if every condition is checked and satisfied once, no need to check again and again
                if(char.IsUpper(letter))
                    hasUpper = true;
                else if(char.IsLower(letter))
                   hasLower = true;
                else if(char.IsDigit(letter))
                   hasDigit = true;
                else if(specialCharacter.Contains(letter))
                    hasSpecialCharacter = true;
            }
            if(prevChar == letter)
                return false;
            prevChar = letter;
        }

        if(hasDigit && hasUpper && hasLower && hasSpecialCharacter && (length >= 8))
            return true;
        else
            return false;
        return false;
    }
}
