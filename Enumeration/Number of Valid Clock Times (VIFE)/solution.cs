public class Solution {
    public int CountTime(string time) {
        string[] splittedData = time.Split(':');
        string hour = splittedData[0];
        string minute = splittedData[1];
        int validHourCounter = 0;
        int validMinuteCounter = 0;

        if (!time.Contains("?")) // if not "?", then only one valid time will be present
            return 1;

        validHourCounter += CheckHour(hour);
        validMinuteCounter += CheckMinute(minute);

        if (validHourCounter != 0 && validMinuteCounter != 0)
            return validHourCounter * validMinuteCounter;
        else if (validHourCounter != 0)
            return validHourCounter;
        else if (validMinuteCounter != 0)
            return validMinuteCounter;
        return 0;
    }

    int CheckHour(string hour)
    {
        int validTimeCounter = 0;
        if (hour[0] == '?' && hour[1] == '?')
            return 24;
        else if (hour[0] == '?')
        {
            string lhs = "0";
            while (int.Parse(lhs + hour[1]) < 24)
            {
                validTimeCounter++;
                lhs = (int.Parse(lhs) + 1).ToString();
            }
        }
        else if (hour[1] == '?')
        {
            string rhs = "0";
            string initialValue = (int.Parse(hour[0].ToString()) + 1).ToString() + rhs;
            while (int.Parse(hour[0] + rhs) < 24)
            {
                validTimeCounter++;
                rhs = (int.Parse(rhs) + 1).ToString();
                if (int.Parse(hour[0] + rhs) == int.Parse(initialValue)) // so as to break from the loop once it crosses 10,20,30 ....60
                    break;
            }
        }
        return validTimeCounter;
    }

    int CheckMinute(string minute)
    {
        int validTotalCounter = 0;
        if (minute[0] == '?' && minute[1] == '?')
            return 60;
        if (minute[0] == '?')
        {
            string lhs = "0";
            while (int.Parse(lhs + minute[1]) < 60)
            {
                validTotalCounter++;
                lhs = (int.Parse(lhs) + 1).ToString();
            }
        }
        else if (minute[1] == '?')
        {
            string rhs = "0";
            string initialValue = (int.Parse(minute[0].ToString()) + 1).ToString() + rhs;
            while (int.Parse(minute[0] + rhs) < 60)
            {
                validTotalCounter++;
                rhs = (int.Parse(rhs) + 1).ToString();
                if (int.Parse(minute[0] + rhs) == int.Parse(initialValue))  // so as to break from the loop once it crosses 10,20,30 ....60
                    break;
            }
        }
        return validTotalCounter;
    }
 }
