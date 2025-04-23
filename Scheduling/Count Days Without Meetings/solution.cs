public class Solution {
    public int CountDays(int days, int[][] meetings) {
         if (meetings.Length == 0) return days; // If no meetings, all days are free

        // Step 1: Sort meetings by start day
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        // Step 2: Merge intervals and count meeting days
        int totalMeetingDays = 0;
        int start = meetings[0][0], end = meetings[0][1];

        foreach (var meeting in meetings) {
            if (meeting[0] > end + 1) { // Non-overlapping interval found
                totalMeetingDays += (end - start + 1);
                start = meeting[0];
                end = meeting[1];
            } else { // Overlapping or continuous interval, merge it
                end = Math.Max(end, meeting[1]);
            }
        }
        totalMeetingDays += (end - start + 1); // Add last interval

        return days - totalMeetingDays; // Free days = Total days - Meeting days
    }
}
