public class Solution {
    public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience) {
        int trainingTime = 0;
        int energyTotal = energy.Sum();

        if(energyTotal >= initialEnergy){
            trainingTime = (energyTotal - initialEnergy) + 1;
            initialEnergy += trainingTime;
        }

        foreach (int exp in experience) {
            if (initialExperience <= exp) {
                int diff = exp - initialExperience + 1;
                trainingTime += diff;
                initialExperience += diff;
            }
            initialExperience += exp;
        }
        return trainingTime;
    }
}
