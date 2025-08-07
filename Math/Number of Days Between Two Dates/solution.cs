public class solution
{
    Dictionary<int, int> days = new Dictionary<int, int>(){{1,31},{3,31},{4,30},{5,31},{6,30},{7,31},{8,31},
                                                            {9,30},{10,31},{11,30},{12,31}};
    int numberOfDays = 0;
    int year1 = 0; int year2 = 0;
    int month1 = 0; int month2 = 0; 
    int firstDate = 0; int secondDate2 = 0;
    
    public int DaysBetweenDates(string date1, string date2)
    {

    }

    public int DaysInGivenMonth(int month, int year)
    {
        if (month == 2)
        {
            if (IsLeapYear(year))
                return 29;
            else
                return 28;
        }
        else
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
        }
        else if (date1 < date2)
        {
            while (date1 != date2)
            {
                numberOfDays++;
                date1++;
            }
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
