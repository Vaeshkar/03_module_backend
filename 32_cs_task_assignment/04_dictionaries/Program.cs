// Part 4: Dictionaries
using System.Collections.Generic;

/*
Performance: fast lookup times for keys, but slower for values.
*/

// Declaration and initialization
Dictionary<string, int> ages = new Dictionary<string, int>();

// Adding key-value pairs
ages.Add("Alice", 25);
ages.Add("Bob", 30);
ages["Charlie"] = 35;  // Alternative syntax


// Or initialize with values
Dictionary<string, string> capitals = new Dictionary<string, string>
{
    {"USA", "Washington D.C."},
    {"France", "Paris"},
    {"Japan", "Tokyo"}
};

Dictionary<string, int> scores = new Dictionary<string, int>
{
    {"Alice", 95},
    {"Bob", 87},
    {"Charlie", 92}
};

// Accessing values
Console.WriteLine("Alice's score: " + scores["Alice"]);  // 95


// Safe access (won't throw exception if key doesn't exist)
if (scores.TryGetValue("David", out int score))
{
    Console.WriteLine($"David's score: {score}");
}
else
{
    Console.WriteLine("David not found");
}

// Checking for keys
if (scores.ContainsKey("Bob"))
{
    Console.WriteLine("Bob is in the dictionary");
}


// Iterating
foreach (KeyValuePair<string, int> pair in scores)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// Or iterate keys/values separately
foreach (string name in scores.Keys)
{
    Console.WriteLine($"Name: {name}");
}


///////////////////
// Dictionaries Limitations

// Dictionaries are not ordered.
// Dictionaries cannot contain duplicate keys.
// Dictionaries are not thread-safe.
