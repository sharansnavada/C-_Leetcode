
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






# 4) Array Traversal (Forward and Backward in Circular Manner)

To traverse an array back and forth within a single loop using modulo:

- **Next index (forward traversal):**

```csharp
arr[((i + 1) % n + n) % n]
```

- **Previous index (backward traversal):**

```csharp
arr[((i - 1) % n + n) % n]
```

### Explanation:
- `% n` ensures the index wraps around within the array length.
- Adding `+ n` before applying `% n` again handles negative values of `i`, ensuring the index always stays within `[0, n-1]`.

---

### Example in C#

Suppose we have an array:

```csharp
int[] arr = { 10, 20, 30, 40, 50 };
int n = arr.Length;
```

We want to print the next and previous element of each index in a circular way:

```csharp
for (int i = 0; i < n; i++)
{
    int nextIndex = ((i + 1) % n + n) % n;
    int prevIndex = ((i - 1) % n + n) % n;

    Console.WriteLine($"Index {i}, Value: {arr[i]}");
    Console.WriteLine($"   Next: {arr[nextIndex]}");
    Console.WriteLine($"   Previous: {arr[prevIndex]}");
}
```

### Output:
```
Index 0, Value: 10
   Next: 20
   Previous: 50

Index 1, Value: 20
   Next: 30
   Previous: 10

Index 2, Value: 30
   Next: 40
   Previous: 20

Index 3, Value: 40
   Next: 50
   Previous: 30

Index 4, Value: 50
   Next: 10
   Previous: 40
```

This shows how the formula allows circular traversal:
- From the last element, "next" goes to the first.
- From the first element, "previous" goes to the last.


#5) Bitmask Formula to Represent Characters in a Word

### Formula
```csharp
key |= 1 << (ch - 'a');
```

### Explanation
This formula uses **bitwise operations** to represent which letters (a–z) appear in a word using a single integer.

#### Step-by-step breakdown
1. **`ch - 'a'`** → Converts the character to a number between 0 and 25.
   - `'a' - 'a' = 0`
   - `'b' - 'a' = 1`
   - `'c' - 'a' = 2`

2. **`1 << (ch - 'a')`** → Shifts the bit `1` to the left by that number.
   - `'a'` → `1 << 0` → `0001`
   - `'b'` → `1 << 1` → `0010`
   - `'c'` → `1 << 2` → `0100`

3. **`|=`** → Bitwise OR assignment.  
   This turns ON the bit corresponding to that letter in the variable `key`.

   Example:
   ```csharp
   key = 0;               // 0000
   key |= 1 << 0;         // 'a' → 0001
   key |= 1 << 1;         // 'b' → 0011
   key |= 1 << 2;         // 'c' → 0111
   ```

   Final `key` = `0b00000111` → indicates `'a'`, `'b'`, `'c'` are present.

---

#### Visual Representation

```
key before = 00000000000000000000000011
mask       = 00000000000000000000000100
-------------------------------------- OR
key after  = 00000000000000000000000111
                         ↑ ↑ ↑
                        c b a

```

### To check if a character exists
```csharp
(key & (1 << (ch - 'a'))) != 0
```
✅ True → character exists  
❌ False → character not in the word

Example:
```csharp
bool hasA = (key & (1 << ('a' - 'a'))) != 0;  // true
bool hasB = (key & (1 << ('b' - 'a'))) != 0;  // true
bool hasC = (key & (1 << ('c' - 'a'))) != 0;  // true
bool hasD = (key & (1 << ('d' - 'a'))) != 0;  // false
```

---

### To check if multiple characters exist
```csharp
int mask = (1 << ('a' - 'a')) | (1 << ('b' - 'a')) | (1 << ('c' - 'a'));
bool hasAll = (key & mask) == mask;
```

This verifies if `'a'`, `'b'`, and `'c'` are all present in the same word.
