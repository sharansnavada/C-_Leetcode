using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Projects
{
    public class Solution
    {
        public int MinMirrorPairDistance(int[] nums)
        {
            int length = nums.Length;
            int[] reversedNums = ReverseArrayElement(nums, length);
            int minDistance = int.MaxValue;

            for(int i = 0; i < length; i++)
            {
                for(int j = i + 1; j < length; j++)
                {
                    if (reversedNums[i] == nums[j])
                    {
                        minDistance = Math.Abs(i - j) < minDistance ? Math.Abs(i - j) : minDistance;
                    }
                }
            }

            return minDistance == int.MaxValue ? -1 : minDistance;
        }

        public int[] ReverseArrayElement(int[] num, int length)
        {
            int[] retArr = new int[length];
            int index = 0;

            foreach (int number in num)
            {
                StringBuilder sb = new StringBuilder();
                int currNumber = number;
                while (currNumber > 0)
                {
                   // sb.Insert(0, (currNumber % 10).ToString());
                    sb.Append((currNumber % 10).ToString());
                    currNumber = currNumber / 10;
                }
                retArr[index++] = int.Parse(sb.ToString().TrimStart('0'));

            }
            return retArr;

        }
    }
}

