public class Solution
{
    Dictionary<int, int> days = new Dictionary<int, int>() {
        {1, 31}, {3, 31}, {4, 30}, {5, 31}, {6, 30}, {7, 31},
        {8, 31}, {9, 30}, {10, 31}, {11, 30}, {12, 31}
    };

    int numberOfDays = 0;
    int year1 = 0; int year2 = 0;
    int month1 = 0; int month2 = 0;
    int firstDate = 0; int secondDate = 0;

    public int DaysBetweenDates(string date1, string date2)
    {
        AssignSplittedData(date1, ref year1, ref month1, ref firstDate);
        AssignSplittedData(date2, ref year2, ref month2, ref secondDate);

        CalculateYear();
        return numberOfDays;
    }

    public void CalculateYear()
    {
        if (year1 == year2)
        {
            while (month1 != month2)
            {
                numberOfDays += DaysInGivenMonth(month1, year1);
                month1++;
            }
            numberOfDays = NumberOfDays(firstDate, secondDate, numberOfDays);
        }
        else
        {
            while (year1 != year2 - 1)
            {
                numberOfDays += IsLeapYear(year1) ? 366 : 365;
                year1++;
            }

            while ((month1 != month2 || year1 != year2))
            {
                numberOfDays += DaysInGivenMonth(month1, year1);

                if (month1 == 12)
                {
                    year1++;
                    month1 = 0;
                }

                month1++;
            }
            numberOfDays = NumberOfDays(firstDate, secondDate, numberOfDays);
        }
    }

    public void AssignSplittedData(string date, ref int year, ref int month, ref int Date)
    {
        string[] splitData = date.Split('-');
        year = int.Parse(splitData[0]);
        month = int.Parse(splitData[1]);
        Date = int.Parse(splitData[2]);
    }

    public int DaysInGivenMonth(int month, int year)
    {
        if (month == 2)
        {
            return IsLeapYear(year) ? 29 : 28;
        }
        return days[month];
    }

    public int NumberOfDays(int date1, int date2, int numberOfDays)
    {
        if (date1 > date2)
        {
            while (date1 != date2)
            {
                numberOfDays--;
                date1--;
            }
            // if (date1 == date2 && date1 == secondDate)
            //     numberOfDays++; // include the end date only when necessary
        }
        else if (date1 < date2)
        {
            while (date1 != date2)
            {
                numberOfDays++;
                date1++;
            }
            // if (date1 == date2 && date1 == secondDate)
            //     numberOfDays++; // include the end date only when necessary
        }
        return numberOfDays;
    }

    public bool IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
                return year % 400 == 0;
            return true;
        }
        return false;
    }
}


//Optimized and approved code
public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        return Math.Abs(ToDays(date1) - ToDays(date2));
    }

    private int ToDays(string date)
    {
        string[] parts = date.Split('-');
        int year = int.Parse(parts[0]);
        int month = int.Parse(parts[1]);
        int day = int.Parse(parts[2]);

        int days = 0;

        // add days for full years before current year
        for (int y = 1971; y < year; y++)
        {
            days += IsLeap(y) ? 366 : 365;
        }

        // add days for full months before current month
        int[] monthDays = { 31, IsLeap(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        for (int m = 1; m < month; m++)
        {
            days += monthDays[m - 1];
        }

        // add days in current month
        days += day;

        return days;
    }

    private bool IsLeap(int year)
    {
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        return year % 4 == 0;
    }
}
