public class Solution {
    public long DividePlayers(int[] skill) {
        if(skill.Length < 3) return skill[0] * skill[1];
        skill.Sort();
        int sum = skill.Sum();
        List<int[]> ls = new List<int[]>(skill.Length / 2);
        float targetSum = (float)sum / ((skill.Length / 2));
        if(targetSum % 1 != 0) return -1;
        long retSum = 0;

        for(int i = 0; i < skill.Length; i++)
        {
            int[] arr = new int[2];
            int num = skill[i];
            if (num == -1) continue;
            int lastIndex = skill.Length - 1;
            bool foundPair = false;

            while(lastIndex >= 0)
            {
                if(skill[lastIndex] != -1 && skill[lastIndex] + num == targetSum)
                {
                    foundPair = true;
                    arr[0] = num; arr[1] = skill[lastIndex];
                    skill[lastIndex] = -1;
                    ls.Add(arr);
                    break;
                }
                lastIndex--;
            }
            if(!foundPair) return -1;
        }
        foreach(int[] ar in ls)
        {
            long mul = 1;
            foreach(int n in ar)
            {
                mul *= n;
            }
            retSum += mul;
        }
        return retSum;
    }
}
