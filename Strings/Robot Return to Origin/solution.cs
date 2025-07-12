public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0; int y = 0;
        foreach(char mov in moves){
            switch (mov)
            {
                case 'R':
                    x++;
                    break;
                case 'L':
                    x--;
                    break;
                case 'U':
                    y++;
                    break;
                case 'D': y--;
                    break;
            }
        }

        return x == 0 && y == 0;
    }
}
