//yappa yappa yappa nija onde flow alli barde, olle istond for loop na baaige bandang haakidhini
// pakka aagalla ee problem yella testcases ankondre without any err 100% beats with time complexity ayythu yayyyyy
public class Solution {
    public int MinimumSum(int num) {
        string numStr = num.ToString();
        int minNumber = int.MaxValue;
        
        for(int i = 0; i < numStr.Length; i++){
            for(int j = 0; j < numStr.Length; j++){
                if(i != j){
                    int firstPair = int.Parse(numStr[i].ToString() + numStr[j].ToString());
                    for(int k = 0; k < numStr.Length; k++){
                        if(k != i && k != j){
                            string nums = numStr[k].ToString();
                            for(int l = 0; l < numStr.Length; l++){
                                if(l != i && l != j && l != k){
                                    int secondPair = int.Parse(nums + numStr[l]);
                                    if(firstPair + secondPair < minNumber)
                                        minNumber = firstPair + secondPair;                                }
                            }
                        }
                    }
                }
            }
        }
        return minNumber;
    }
}
