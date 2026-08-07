class Solution:
    def findPermutationDifference(self, s: str, t: str) -> int:
        s_data = {}
        t_data = {}
        sum = 0

        for i in range(len(s)):
            s_data[s[i]] = i
        for i in range(len(t)):
            t_data[t[i]] = i

        for letter in s:
            sum = sum + abs(s_data[letter] - t_data[letter])
        
        return sum
