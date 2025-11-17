Given an binary array nums and an integer k, return true if all 1's are at least k places away from each other, otherwise return false.

 

Example 1:

<img width="428" height="181" alt="image" src="https://github.com/user-attachments/assets/a39fc1e0-b7da-4241-b309-6ca3e7017bea" />

Input: nums = [1,0,0,0,1,0,0,1], k = 2
Output: true
Explanation: Each of the 1s are at least 2 places away from each other.
Example 2:

<img width="320" height="173" alt="image" src="https://github.com/user-attachments/assets/70feb263-2e17-4bbb-9643-cda5e8e9322d" />

Input: nums = [1,0,0,1,0,1], k = 2
Output: false
Explanation: The second 1 and third 1 are only one apart from each other.
 

Constraints:

1 <= nums.length <= 105
0 <= k <= nums.length
nums[i] is 0 or 1
