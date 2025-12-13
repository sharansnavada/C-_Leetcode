You are given a 2D matrix grid of size m x n. You need to check if each cell grid[i][j] is:

Equal to the cell below it, i.e. grid[i][j] == grid[i + 1][j] (if it exists).
Different from the cell to its right, i.e. grid[i][j] != grid[i][j + 1] (if it exists).
Return true if all the cells satisfy these conditions, otherwise, return false.

 

Example 1:

Input: grid = [[1,0,2],[1,0,2]]

Output: true

Explanation:

<img width="254" height="186" alt="image" src="https://github.com/user-attachments/assets/b1cdf01b-8ae3-4415-8d4b-83d1aec8ebb6" />



All the cells in the grid satisfy the conditions.

Example 2:

Input: grid = [[1,1,1],[0,0,0]]

Output: false

Explanation:

<img width="254" height="186" alt="image" src="https://github.com/user-attachments/assets/d5bd6e02-e822-4e23-be51-f32abb082471" />


All cells in the first row are equal.

Example 3:

Input: grid = [[1],[2],[3]]

Output: false

Explanation:

<img width="86" height="277" alt="image" src="https://github.com/user-attachments/assets/2206fe03-b964-400e-b57c-e8d06238806f" />


Cells in the first column have different values.

 

Constraints:

1 <= n, m <= 10
0 <= grid[i][j] <= 9
