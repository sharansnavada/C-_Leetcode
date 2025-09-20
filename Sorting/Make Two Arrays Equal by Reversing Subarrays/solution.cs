public class Solution {
    public bool CanBeEqual(int[] target, int[] arr)
    {
        for (int i = 0; i < target.Length; i++)
        {
            Dictionary<bool, int[]> dict = GetReversedArray(arr, target[i], i);
            if (dict.Keys.First() == true) 
                arr = dict[true];
            else
                return false;
        }
        return true;
    }
    public Dictionary<bool, int[]> GetReversedArray(int[] arr, int targetElement, int index){
        Dictionary<bool, int[]> dict = new Dictionary<bool, int[]>();
        int itr = index; bool hasTarget = false;
        List<int> targetList = new List<int>();
        List<int> concatinateingList = new List<int>();

        for (int j = 0; j < index; j++)
        {
            concatinateingList.Add(arr[j]);
        }

        while (itr < arr.Length)
        {
            if (!hasTarget)
                targetList.Insert(0, arr[itr]);
            else
                targetList.Add(arr[itr]);

            if (arr[itr] == targetElement)
                hasTarget = true;
            itr++;
        }
        concatinateingList.AddRange(targetList);
        dict[hasTarget] = concatinateingList.ToArray();

        return dict;
    }
}
