

# Binary to Decimal Conversion Formula

## Formula

**bit = bit * 2 + nums[i];** //////////////////


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


**decimal = decimal * 2 + current_bit;** //////////

---

## **Summary**
- **Formula:**  
  
  bit = bit * 2 + nums[i];  //////////////////

- **Meaning:**  
  Multiply the current decimal value by **2** (shift left) and **add the current bit**.
- **Use Case:**  
  Used when converting **binary → decimal** or while handling **binary prefix calculations**.
