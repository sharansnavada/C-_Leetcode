public class Solution {
    public int MaximumPopulation(int[][] logs) {
        Dictionary<int, int> yearBook = new Dictionary<int, int>();

        for (int i = 0; i < logs.Length; i++)
        {
            int birth = logs[i][0];
            int death = logs[i][1];

            for (int year = birth; year < death; year++)
            {
                if (!yearBook.ContainsKey(year))
                    yearBook[year] = 0;
                yearBook[year]++;
            }
        }

        int maxTimes = 0;
        int maxYear = 1950;

        foreach (var year in yearBook.Keys)
        {
            if (yearBook[year] > maxTimes || (yearBook[year] == maxTimes && year < maxYear))
            {
                maxTimes = yearBook[year];
                maxYear = year;
            }
        }

        return maxYear;
    }
}
