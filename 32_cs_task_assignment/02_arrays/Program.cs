// Part 2: Arrays

/*
# What is an Array?

Fixed-size collection of elements of the same type
Elements are stored in contiguous memory locations
Zero-indexed (first element is at index 0)
Performance: fast
Index to Value
 */

// Declaration and initialization
int[] numbers = new int[5];           // Array of 5 integers (all 0)

string[] names = { "Alice", "Bob", "Charlie" };  // Array literal
Console.WriteLine("Array of names: " + string.Join(", ", names)); // All names

int[] values = new int[] { 10, 20, 30, 40, 50 }; // Explicit initialization
Console.WriteLine("Array of values: " + string.Join(", ", values));  // All values

// Accessing elements
Console.WriteLine("First number: " + numbers[0]);  // First element
numbers[2] = 42;               // Set third element

// Properties and Methods
int[] data = {1, 2, 3, 4, 5};

Console.WriteLine("Length: " + data.Length);        // 5 (number of elements)
Array.Sort(data);                                   // Sort the array
int index = Array.IndexOf(data, 3);                 // Find index of value 3


///////////////////
// Array Limitations

// Fixed size - can't grow or shrink after creation
// No built-in methods to add/remove elements
