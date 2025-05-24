/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int l = 1, r = n;
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (IsBadVersion(mid) == true) r = mid - 1;
            else l = mid + 1;
        }
        return l;
    }
} // this is the optimized code done using Binary search method.

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

/*public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        for(int i = n ; i > 0 ; i--){
            if(!IsBadVersion(i)){
                return i + 1;
            }
        }
        return 1;
    }
}*/ //this is my  code having worst time complexity
