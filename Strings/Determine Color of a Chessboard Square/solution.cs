public class Solution {
    public bool SquareIsWhite(string coordinates) {
        char coordinate1 = coordinates[0];
        int coordinate2 = (int)coordinates[1];

        switch(coordinate1){
            case('a'):
            case('c'):
            case('e'):
            case('g'): if(coordinate2 % 2 == 0){
                            return true;
            }else{
                return false;
            }

            case('b'):
            case('d'):
            case('f'):
            case('h'): if(coordinate2 % 2 == 0){
                            return false;
            }
            else
            {
                return true;
            }

        }
        return false;
    }
}


//one line code from other programmer ----------->
// public class Solution {
//     public bool SquareIsWhite(string coordinates) {
//         return (coordinates[0] - 'a') % 2 == (coordinates[1] - '0') % 2;
//     }
// }
