public class Solution {
    public long DividePlayers(int[] skill) {
        if(skill.Length < 3) return skill[0] * skill[1];
        skill.Sort();
        int sum = skill.Sum();
        if(sum % 2 != 0) return -1;
        List<int[]> ls = new List<int[]>(skill.Length / 2);
        int targetSum = sum / ((skill.Length / 2));
        int retSum = 0;

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
            int mul = 1;
            foreach(int n in ar)
            {
                mul *= n;
            }
            retSum += mul;
        }
        return retSum;
    }
}
