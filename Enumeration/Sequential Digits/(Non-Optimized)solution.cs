public class SD {
    public IList<int> SequentialDigits(int low, int high) {
        List<int> retList = new List<int>();
 
        for(int i = low; i <= high; i++){
            bool isFirstDigit = true;
            int previousDigit = 0;
            int currentDigit = 0;
            int tempDigit = i;
            bool isSequentialDigit = true;
 
            while(tempDigit > 0){
                currentDigit = tempDigit % 10;
                tempDigit = tempDigit / 10;
               
                if(isFirstDigit){
                    isFirstDigit = false;
                }
                else{
                    if(currentDigit == previousDigit - 1)
                    {
                        isSequentialDigit = true;
                    }
                    else
                    {
                        isSequentialDigit = false;
                        break;
                    }
                    
                }
 
                previousDigit = currentDigit;
            }
            if(isSequentialDigit) retList.Add(i);
        }
        return retList;
    }
}
