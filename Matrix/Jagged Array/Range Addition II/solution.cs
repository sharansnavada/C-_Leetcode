//chatgpt's full optimized code
//Don’t allocate or modify orgArr at all. Just calculate the smallest rowLimit and colLimit.
public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        if (ops.Length == 0)
{
    return m * n;
}

int minRow = m;
int minCol = n;

foreach (var op in ops)
{
    minRow = Math.Min(minRow, op[0]);
    minCol = Math.Min(minCol, op[1]);
}

return minRow * minCol;
    }
}


//my code which has worst space complexity for large data
// if (ops.Length == 0)
 //        {
 //            return m * n;
 //        }
 //        int[][] orgArr = new int[m][];
 //        int opsCount = 0;

 //        for (int i = 0; i < orgArr.Length; i++)
 //        {
 //            orgArr[i] = new int[n];
 //        }

 //        int maximumInterger = 0;
 //        Dictionary<int, int> maxIntRecord = new Dictionary<int, int>();
        

 //        while (opsCount != ops.Length)
 //        {
 //            int[] arr = ops[opsCount];
 //            int rowLimit = Math.Min(arr[0], m);
 //            int colLimit = Math.Min(arr[1], n);

 //            for (int i = 0; i < rowLimit; i++)
 //            {
 //                for (int j = 0; j < colLimit; j++)
 //                {
 //                    orgArr[i][j] += 1;

 //                    if (orgArr[i][j] > maximumInterger)
 //                    {
 //                        maximumInterger = orgArr[i][j];
 //                    }

 //                    if (maxIntRecord.ContainsKey(orgArr[i][j]))
 //                        maxIntRecord[orgArr[i][j]]++;
 //                    else
 //                        maxIntRecord[orgArr[i][j]] = 1;
                    
 //                }
 //            }

 //            opsCount++;
 //        }

 //        return maxIntRecord[maximumInterger];
