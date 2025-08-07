using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;

public class nod
{
    Dictionary<int, int> days = new Dictionary<int, int>() {
        {1, 31}, {3, 31}, {4, 30}, {5, 31}, {6, 30}, {7, 31},
        {8, 31}, {9, 30}, {10, 31}, {11, 30}, {12, 31}
    };

    int numberOfDays = 0;
    int year1 = 0, year2 = 0;
    int month1 = 0, month2 = 0;
    int firstDate = 0, secondDate = 0;

    public int DaysBetweenDates(string date1, string date2)
    {
        string[] splitData = date1.Split('-');
        year1 = int.Parse(splitData[2]);
        month1 = int.Parse(splitData[1]);
        firstDate = int.Parse(splitData[0]);

        splitData = date2.Split('-');
        year2 = int.Parse(splitData[2]);
        month2 = int.Parse(splitData[1]);
        secondDate = int.Parse(splitData[0]);

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
                if (month1 == 12)
                {
                    month1++;
                    year1++;
                }
            }
            numberOfDays = NumberOfDays(firstDate, secondDate, numberOfDays);
        }

        while (year1 != year2 - 1)
        {
            numberOfDays += IsLeapYear(year1) ? 366 : 365;
            year1++;
        }

        if (year1 == year2 - 1)
        {
            int numberOfMonths = (month1 + month2) % 12 + 12 - month2;
            while (numberOfMonths != 0)
            {
                numberOfDays += DaysInGivenMonth(month1, year1);
                month1++;
                numberOfMonths--;

                if (month1 == 12)
                {
                    year1++;
                    month1 = 1;
                }
            }

            numberOfDays = NumberOfDays(firstDate, secondDate, numberOfDays);
        }
    }

    public void AssignSplittedData(string date, int year, int month, int Date)
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
