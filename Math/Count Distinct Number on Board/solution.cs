public class Solution {
    public int DistinctIntegers(int n) {
        int count = 0;
        List<int> num = new List<int>();
        List<int> laterList = new List<int>();
        int[] hashTable = new int[101];
        num.Add(n);

        while (true)
        {
            laterList = new List<int>();

            foreach (int nList in num)
            {
                int i = 1;
                for ( i = 1; i <= nList; i++)
                {
                    if (nList % i == 1 && hashTable[i] == 0) 
                    {
                        hashTable[i]++;
                        count++;
                        laterList.Add(i);
                    }
                }
            }

            num = laterList;

            if(num.Count == 0 || (num.Count == 1 && num.Contains(2))){
                return count + 1;
            }
            
        }
        return count;
    }
}
