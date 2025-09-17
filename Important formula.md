
# 1) Binary to Decimal Conversion Formula

## Formula

**bit = bit * 2 + nums[i];** 


---

## Explanation
This formula is used to **convert a binary number** (given as an array of bits) into its **decimal value** step by step.

- **`bit * 2`** → shifts the current value **one place left** in binary.
- **`+ nums[i]`** → adds the current bit (`0` or `1`).

---

## **Example**

Input:

nums = [1, 0, 1, 1]; // Binary = 1011


Step-by-step calculation:

| i | nums[i] | Formula            | bit (decimal) |
|---|---------|--------------------|---------------|
| 0 |   1     | 0*2 + 1            | 1             |
| 1 |   0     | 1*2 + 0            | 2             |
| 2 |   1     | 2*2 + 1            | 5             |
| 3 |   1     | 5*2 + 1            | 11            |

Final Decimal Value:

1011 (binary) = 11 (decimal)


---
## General Concept

For a binary number `b₀ b₁ b₂ ... bn`:

\[
decimal = (((b₀ * 2 + b₁) * 2 + b₂) * 2 + ... + bn)
\]

Or simply:


**decimal = decimal * 2 + current_bit;** 

---

## **Summary**
- **Formula:**  
  
  **bit = bit * 2 + nums[i];**  

- **Meaning:**  
  Multiply the current decimal value by **2** (shift left) and **add the current bit**.
- **Use Case:**  
  Used when converting **binary → decimal** or while handling **binary prefix calculations**.





  
# 2) Decimal to Binary Conversion in C#

There are two main ways to convert a decimal number into binary:

---

### 1. Manual Division Method  
This is the mathematical approach:  
1. Divide the number by 2.  
2. Record the remainder (0 or 1).  
3. Update the quotient as the result of division.  
4. Repeat steps until the quotient becomes 0.  
5. The binary form is the sequence of remainders read in **reverse order**.  

**Example:** Convert 6 → Binary  
- 6 ÷ 2 = 3, remainder = 0  
- 3 ÷ 2 = 1, remainder = 1  
- 1 ÷ 2 = 0, remainder = 1  
Reading remainders backwards → **110**  

This is how the conversion works internally.  

---

### 2. Built-in C# Method (`Convert.ToString`)  
C# provides a ready method:  

int number = 25;
string binary = Convert.ToString(number, 2);
Console.WriteLine(binary); // Output: 11001

- The first argument is the decimal number.  
- The second argument is the base (`2` for binary, `8` for octal, `10` for decimal, `16` for hex).  
- Internally, this method also uses the **division and remainder** technique but saves us from implementing it manually.  

**Examples:**  
Convert.ToString(255, 2);  // "11111111"
Convert.ToString(255, 16); // "ff"

---

⚡ In short:  
- **Formula approach (manual)** → Divide by 2, collect remainders, reverse them.  
- **C# built-in** → Use `Convert.ToString(number, 2)` for quick conversion.
***






# 3) Finding the Mid in Binary Search

In binary search, we repeatedly divide the search range into two halves. To do this, we calculate the **middle index** (`mid`) of the current search range.

---

### Basic Formula
**int mid = (low + high) / 2;**

- `low` → starting index of the current search range.
- `high` → ending index of the current search range.
- `mid` → middle index between `low` and `high`.

---
### Problem with the Basic Formula
The formula `(low + high) / 2` **may cause integer overflow** if `low` and `high` are very large.

**Example:**
int low = 1_000_000_000;
int high = 2_000_000_000;
int mid = (low + high) / 2;  // ❌ Overflow risk

---
### Safe Formula
To avoid overflow, we calculate `mid` like this:

**int mid = low + (high - low) / 2;**

---
#### Why This Works
- `high - low` → gives the size of the current range (never overflows).
- `(high - low) / 2` → gives half of the range.
- `low + ...` → shifts from the start index to the middle.

### Example

int[] arr = {1, 3, 5, 7, 9};
int low = 0, high = arr.Length - 1;

while (low <= high)
{
    int mid = low + (high - low) / 2; // ✅ Safe mid formula

    if (arr[mid] == 7)
        return mid; // found
    else if (arr[mid] < 7)
        low = mid + 1; // search right half
    else
        high = mid - 1; // search left half
}

---
### Summary Table

| Formula                         | Risk of Overflow | Recommended? |
| ------------------------------ | ---------------- | ------------ |
| `mid = (low + high) / 2`       | **Yes**          | ❌ No        |
| `mid = low + (high - low) / 2` | **No**           | ✅ Yes       |
