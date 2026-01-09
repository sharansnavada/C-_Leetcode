public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int testedDevice = 0;
        int n = batteryPercentages.Length;

        for(int i = 0; i < n; i++){
            if(batteryPercentages[i] > 0){
                for(int j = i + 1; j < n; j++){
                    batteryPercentages[j] = batteryPercentages[j] - 1 >= 0 ? batteryPercentages[j] - 1 : 0;
                }
                testedDevice++;
            }
        }
        return testedDevice;
    }
}
