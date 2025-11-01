You are given an array of integers nums and the head of a linked list. Return the head of the modified linked list after removing all nodes from the linked list that have a value that exists in nums.

 

Example 1:

Input: nums = [1,2,3], head = [1,2,3,4,5]

Output: [4,5]

Explanation:

<img width="652" height="107" alt="image" src="https://github.com/user-attachments/assets/b077e9c1-85b1-4332-827a-536aa4d6a5ff" />


Remove the nodes with values 1, 2, and 3.

Example 2:

Input: nums = [1], head = [1,2,1,2,1,2]

Output: [2,2,2]

Explanation:

<img width="788" height="108" alt="image" src="https://github.com/user-attachments/assets/f3d684b1-2803-45b0-84c0-907497717d18" />


Remove the nodes with value 1.

Example 3:

Input: nums = [5], head = [1,2,3,4]

Output: [1,2,3,4]

Explanation:

<img width="514" height="107" alt="image" src="https://github.com/user-attachments/assets/29624ded-2e4d-4cbb-ad42-5e01eb18a672" />


No node has value 5.

 

Constraints:

1 <= nums.length <= 105
1 <= nums[i] <= 105
All elements in nums are unique.
The number of nodes in the given list is in the range [1, 105].
1 <= Node.val <= 105
The input is generated such that there is at least one node in the linked list that has a value not present in nums.
