public class Solution {
    public int NumberOfChild(int n, int k) {
        int child = -1;
        int ballReached = 0; bool forward = true;
        bool hasReversed = false;

        while (ballReached <= k)
        {
            if (forward)
            {
                child++;
                forward = (child) == n - 1 ? !forward : forward;
                //if (!forward) child--;
            }
            else
            {
                child--;
                forward = (child) == 0 ? !forward : forward;
                hasReversed = true;
            }
            ballReached++;
        }
        // child = hasReversed ? child : child - 1;
        return child;
    }
}
