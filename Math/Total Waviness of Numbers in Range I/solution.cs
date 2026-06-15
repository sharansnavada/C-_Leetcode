public class Solution {
    public int TotalWaviness(int num1, int num2) {
        int totalWaviness = 0;

        for(int i = num1; i <= num2; i++){
            string n = i.ToString();
            if(n.Length < 3) continue;

            for(int j = 1; j < n.Length - 1; j++){
                if((int.Parse(n[j].ToString()) > int.Parse(n[j + 1].ToString()) && int.Parse(n[j].ToString()) > int.Parse(n[j - 1].ToString())) || (int.Parse(n[j].ToString()) < int.Parse(n[j + 1].ToString()) && int.Parse(n[j].ToString()) < int.Parse(n[j - 1].ToString()))){
                    totalWaviness++;
                }
            }
        }
        return totalWaviness;
    }
}
