// Time complexity will be less if we use binary search as array would be in ascending order
public class lexi
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int low = 0;
        int high = letters.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (letters[mid] <= target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        // Wrap around if not found
        return low < letters.Length ? letters[low] : letters[0];
    }
}

//Not great time complexity but average code of mine
// public class lexi {
//     public char NextGreatestLetter(char[] letters, char target) {
//         int targetAscii = (int)target;
//         int greaterThanTarget = (int)'z' + 1;
//         bool foundNextTarget = false;

//         foreach(char letter in letters){
//             if(((int)letter) > targetAscii){
//                 if((int)letter < greaterThanTarget){
//                     greaterThanTarget = (int)letter;
//                     foundNextTarget = true;
//                 }
//             }
//         }

//         if(foundNextTarget)
//             return (char)greaterThanTarget;
//         else
//             return letters[0];
//     }
// }
