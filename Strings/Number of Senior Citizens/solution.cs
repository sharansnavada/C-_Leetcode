public class Solution {
    public int CountSeniors(string[] details) {
        return details.Count(a => (int.Parse(a[11].ToString()) > 6 &&
                    int.Parse(a[12].ToString()) >= 0) || (int.Parse(a[11].ToString()) >= 6 &&
                    int.Parse(a[12].ToString()) > 0));
    }
}
