public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int addOnNumber = 1;
        
        while(true){
            int secondAddOnNumber = (n - addOnNumber);
            bool hasZeroInAddOnNumber = false;
            foreach (char num in addOnNumber.ToString())
            {
                if (num == '0'){
                    addOnNumber++;
                    hasZeroInAddOnNumber = true;
                    break;
                }
            }
            if (!hasZeroInAddOnNumber)
            {
                foreach (char number in secondAddOnNumber.ToString())
                {
                    if (number == '0')
                    {
                        addOnNumber++;
                        hasZeroInAddOnNumber = true;
                        break;
                    }
                }
                if (!hasZeroInAddOnNumber)
                {
                    if (addOnNumber + secondAddOnNumber == n)
                        return new int[] { addOnNumber, secondAddOnNumber };
                    else
                        addOnNumber++;
                }
                
            }
        }
        return new int[]{};
    }
}
