public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int flowerPlaced = 0; 
        int sum = -1; //-1 because we will check this in else condition, if flowerbed is [0] or [0],[1] then we'll check whether sum of these two are 0 or 1, if 0 we'll return true else 1.

        if (flowerbed.Length >= 2)
        {
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                flowerPlaced++;
            }

            if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0)
            {
                flowerbed[flowerbed.Length - 1] = 1;
                flowerPlaced++;
            }

            if (flowerPlaced >= n)
            {
                return true;
            }

            for (int i = 1; i <= flowerbed.Length - 2; i++)
            {
                if (flowerbed[i + 1] != 1 && flowerbed[i - 1] != 1 && flowerbed[i] != 1)
                {
                    flowerbed[i] = 1; flowerPlaced++;

                    if (flowerPlaced >= n)
                        return true;
                }
            }

        }
        else
        {
            sum = 0;
            foreach (int flowerpot in flowerbed)
            {
                sum += flowerpot;
            }
        }

        if (sum == 0 || n == 0) //n = 0, if no flowers needs to be planted, then flowerbed is fine and we'll return true
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
