//Most optimised approach3: using Dictionary with key value pairs Datatype DSA in C# logic:
// public class Solution {
//     public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
//         Dictionary<int,int> dict = new Dictionary<int,int>();
//         int aliceSum = 0, bobSum = 0;
//         foreach(int candies in aliceSizes){
//             aliceSum += candies;
//         }
//         foreach(int candies in bobSizes){
//             bobSum += candies;
//             if(dict.ContainsKey(candies)){
//                 dict[candies]++;
//             }
//             else{
//                 dict[candies] = 1;
//             }
//         }
//         for(int i = 0; i < aliceSizes.Length;i++){
//             int need = aliceSizes[i] - (aliceSum - bobSum)/2;
//             if(dict.ContainsKey(need)){
//                 return new int[]{aliceSizes[i],need};
//             }
//         }
//         return null;
//     }
// }
public class Solution {
    public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes) {
        bool doesAliceHasMore = true; int aliceSum = aliceSizes.Sum();
        bool doesBobHasMore = true; int bobSum = bobSizes.Sum();;
        

        foreach(int alice in aliceSizes){
            foreach(int bob in bobSizes){
                if(aliceSum - alice + bob == bobSum - bob + alice)
                    return new int[]{alice,bob};
            }
        }

        return new int[]{};
    }
}
