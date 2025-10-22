public class Solution {
    public int DayOfYear(string date) {
        string[] dateData = date.Split('-');

        DateTime specificDate = new DateTime(int.Parse(dateData[0]), int.Parse(dateData[1]), int.Parse(dateData[2]));
        return specificDate.DayOfYear;
    }
}

/*
Creating a DateTime object

DateTime now = DateTime.Now;      // Current date and time
DateTime today = DateTime.Today;  // Today's date (time = 00:00:00)
DateTime utcNow = DateTime.UtcNow; // Coordinated Universal Time (UTC)

DateTime birthday = new DateTime(2002, 7, 25); // Year, Month, Day
DateTime meeting = new DateTime(2025, 10, 22, 14, 30, 0); // Y, M, D, H, M, S

Accessing Components

Console.WriteLine(now.Year);       // e.g., 2025
Console.WriteLine(now.Month);      // e.g., 10
Console.WriteLine(now.Day);        // e.g., 22
Console.WriteLine(now.Hour);       // e.g., 20
Console.WriteLine(now.Minute);     // e.g., 30
Console.WriteLine(now.Second);     // e.g., 15
Console.WriteLine(now.DayOfWeek);  // e.g., Wednesday
Console.WriteLine(now.DayOfYear);  // e.g., 295 (out of 365)

Date Operations
You can add or subtract days, months, years, etc.

DateTime today = DateTime.Today;
DateTime tomorrow = today.AddDays(1);
DateTime nextWeek = today.AddDays(7);
DateTime nextMonth = today.AddMonths(1);
DateTime nextYear = today.AddYears(1);

Console.WriteLine(tomorrow);  // Prints tomorrow’s date

Difference between two dates

DateTime start = new DateTime(2024, 1, 1);
DateTime end = DateTime.Today;
TimeSpan diff = end - start;

Console.WriteLine(diff.Days); // Number of days between the two dates

Formatting Date and Time
You can convert a DateTime to a string using ToString() with format specifiers.

DateTime now = DateTime.Now;

Console.WriteLine(now.ToString("dd/MM/yyyy"));   // 22/10/2025
Console.WriteLine(now.ToString("MMMM dd, yyyy"));// October 22, 2025
Console.WriteLine(now.ToString("hh:mm tt"));     // 08:30 PM
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss")); // 2025-10-22 20:30:00



| Feature           | Example                  | Description              |
|-------------------|--------------------------|--------------------------|
| Get current date  | DateTime.Now             | Includes time            |
| Get today’s date  | DateTime.Today           | Time is 00:00:00         |
| Add 7 days        | today.AddDays(7)         | Returns a new DateTime   |
| Difference        | end - start              | Returns a TimeSpan       |
| Day of week       | today.DayOfWeek          | Returns DayOfWeek enum   |
| Format            | ToString("dd/MM/yyyy")   | Custom format            |
*/
