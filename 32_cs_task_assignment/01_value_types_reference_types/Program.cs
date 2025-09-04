// Part 1: Value Types vs Reference Types

/*
# Value Types:
Store the actual data directly
Live on the stack (usually)
When you copy them, you get a separate copy
Examples: int, bool, char, double, struct, enum
*/

// Value Type Example
int a = 5;
int b = a;  // b gets its own copy of 5
a = 10;     // Only a changes
Console.WriteLine($"a = {a}, b = {b}"); // Output: a = 10, b = 5

/*
# Reference Types:

Store a reference (address) to where the data lives
Data lives on the heap
When you copy them, you copy the reference, not the data
Examples: string, array, List<T>, Dictionary<T,K>, classes
*/

// Reference Type Example
int[] array1 = {1, 2, 3};
int[] array2 = array1;  // array2 points to same location as array1
array1[0] = 99;         // Changes the shared data
Console.WriteLine($"array2[0] = {array2[0]}"); // Output: array2[0] = 99
