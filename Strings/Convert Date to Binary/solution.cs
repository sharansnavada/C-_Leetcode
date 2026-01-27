public class Solution {
    public string ConvertDateToBinary(string date) {
        string[] splittedData = date.Split('-');
        string year = splittedData[0];
        string month = splittedData[1];
        string day = splittedData[2];

        string retString = Convert.ToString(int.Parse(year), 2) + "-" +
                           Convert.ToString(int.Parse(month), 2) + "-" +
                           Convert.ToString(int.Parse(day), 2);

        return retString;

    }
}
