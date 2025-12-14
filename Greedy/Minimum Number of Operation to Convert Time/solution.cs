public class Solution {
    public int ConvertTime(string current, string correct) {
        int count = 0;

        int currentHour = int.Parse(current[0].ToString() + current[1].ToString());
        int currentMinute = int.Parse(current[3].ToString() + current[4].ToString());

        int correctHour = int.Parse(correct[0].ToString() + correct[1].ToString());
        int correctMinute = int.Parse(correct[3].ToString() + correct[4].ToString());

        while(currentHour != correctHour)
        {
            if(currentHour == (correctHour - 1) && currentMinute > correctMinute)
            {
                currentHour++;
                correctMinute = (60 - currentMinute) + correctMinute;
                currentMinute = 0;
            }
            else
            {
                currentHour++; 
                count++;
            }
        }

        while(currentMinute != correctMinute)
        {
            if((currentMinute + 15) <= correctMinute)
            {
                currentMinute += 15;
            }
            else if((currentMinute + 5) <= correctMinute)
            {
                currentMinute += 5;
            }
            else if((currentMinute + 1) <= correctMinute)
            {
                currentMinute += 1;
            }

            count++;
        }

        return count;
    }
}
