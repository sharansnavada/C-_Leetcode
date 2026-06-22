//This problem could be easily done by adding the multiplied current laser row's beam count
// and next available laser row's beam count. Simply to give more work to my brain I did like this
public class Solution {
    public int NumberOfBeams(string[] bank) {
        bool[] hasLaser = new bool[bank.Length];
        int count = 0;

        for(int i = 0; i < bank.Length; i++){
            string s = bank[i];
            foreach(char letter in s){
                if(letter == '1'){
                    hasLaser[i] = true;
                    break;
                }
            }
        }
        
        for(int i = 0; i < bank.Length; i++){
            if(hasLaser[i] == false) continue;
            int currentLaserCount = 0;
            foreach(char letter in bank[i]){
                if(letter == '1') currentLaserCount++;
            }

            int index = i + 1;
            string nextLaser= "";
            int nextLaserCount = 0;

            while(index != bank.Length){
                if(hasLaser[index]){
                    nextLaser = bank[index];
                    break;
                }
                index++;
            }

            foreach(char letter in nextLaser){
                if(letter == '1') nextLaserCount++;
            }

            count += currentLaserCount * nextLaserCount;
        }

        return count;

    }
}
