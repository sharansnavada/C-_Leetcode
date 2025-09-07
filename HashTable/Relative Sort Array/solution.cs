public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int arr1Length = arr1.Length;
        int[] hashTable = new int[1001];
        int[] retArr = new int[arr1Length];
        int i = 0;

        for(int j = 0; j < arr1Length; j++){ // for loop to incrementing the index of the hashtable for arr1
            hashTable[arr1[j]]++;
        }

        foreach(int number in arr2){ // for loop for adding elements in arr2 having index greater than 1 for arr1
            while(hashTable[number] != 0){
                retArr[i] = number;
                hashTable[number]--;
                i++;
            }
        }

        for (int k = 0; k < 1001; k++) // for loop for adding the remaining elements in arr1 that are not present in arr2
        {
            if (hashTable[k] > 0)
            {
                while (hashTable[k] != 0)
                {
                    retArr[i] = k;
                    hashTable[k]--; i++;
                }
            }
        }

        return retArr;
    }
}
