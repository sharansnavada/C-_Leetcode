//the main logic here is, we can get the w which is less than square root of area.
public class Solution {
    public int[] ConstructRectangle(int area) {
        int areaSqrt = (int)Math.Sqrt(area);
        int[] retArr = new int[2];

        for(int i = areaSqrt; i > 0; i--){
            if(area % i == 0){
                retArr[0] = area/i;
                retArr[1] = i;
                return retArr;
            } 
        }
        return retArr;
    }
}
