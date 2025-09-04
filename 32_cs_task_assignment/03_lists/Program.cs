using System.Collections.Generic;

// Part 3: Lists

/*
# What is a List?

Dynamic, arrays that can grow and shrink
Lists and Dictionaries are part of the Generic collections in C#
More flexible than arrays
Performance: good
 */

// Declaration and initialization
List<int> numbers = new List<int>();           // Empty list
List<string> names = new List<string> {"Alice", "Bob"};  // With initial values

// Adding elements
numbers.Add(10);
numbers.Add(20);
numbers.AddRange(new int[] {30, 40, 50});  // Add multiple items

List<string> fruits = new List<string> {"apple", "banana", "orange"};

// Accessing
Console.WriteLine("First fruit: " + fruits[0]);     // "apple"
Console.WriteLine("Number of fruits: " + fruits.Count);  // 3

// Adding/Removing
fruits.Add("grape");              // Add to end
fruits.Insert(1, "kiwi");         // Insert at index 1
fruits.Remove("banana");          // Remove first occurrence
fruits.RemoveAt(2);              // Remove at specific index

// Searching
bool hasApple = fruits.Contains("apple");
int index = fruits.IndexOf("grape");


// Iteration
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
