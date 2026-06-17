public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        
        IList<IList<int>> retList = new List<IList<int>>();
        
        for(int i = 0; i < groupSizes.Length; i++){
            if(!dict.ContainsKey(groupSizes[i]))
                dict[groupSizes[i]] = new List<int>();
            dict[groupSizes[i]].Add(i);
        }

        foreach(KeyValuePair<int, List<int>> kvp in dict)
        {
            int n = kvp.Value.Count;
            int arrSize = kvp.Key;
            int listIndex = 0;
          
            while(n != 0)
            {
                int[] arr = new int[arrSize];
                int index = 0;
              
                while(index != arr.Length)
                {
                    arr[index++] = kvp.Value[listIndex++];
                    n--;
                }
                retList.Add(arr);
                index = 0; // no need of this
            }
        }
        return retList;
    }
}
