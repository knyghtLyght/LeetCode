# ZigZag String

Coding challeneges presented by LeetCode

## Challenge

The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

```
P   A   H   N
A P L S I I G
Y   I   R
```

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);  
Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"

Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:

```
P     I    N
A   L S  I G
Y A   H R
P     I
```

## Solution

I settled on the intervel between the peeks of the zigzag. focusing on the intervel per row i came up with 2*(n-1) for the first and last row. The internal rows are more difficult but each row still uses the 2*(n-1) but the additional letters are found with the formula currentStringPosition + 2 \* (numRows - 1 - currentRow) < the length of the string argument.
