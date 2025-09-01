// import the namespace
using Utils;
using System;

/* Greeter.Welcome(name: "John");
Greeter.Welcome(course: "C# Advanced");
Greeter.Welcome();
Greeter.Welcome("Priya", "ASP.NET");
 */

// call both Caculator methods
Console.WriteLine(Calculator.Add(1, 2)); // 3
Console.WriteLine(Calculator.Multiply(2, 2)); // 4


// Overload and return types
// use double add
Console.WriteLine(Calculator.Add(2.3, 4.6));
// use double divide
Console.WriteLine(Calculator.Divide(10, 2));
// don't divide by zero
Console.WriteLine(Calculator.Divide(10, 0));

// Statistics
Console.WriteLine(Statistics.Average(1, 2)); // 1.5, no 3 ommited, calculate only 2
Console.WriteLine(Statistics.Average(1, 2, 3)); // 2

// Formatter with modultiple overloads
Console.WriteLine(Formatter.FormatNumber(1)); // Number: 1
Console.WriteLine(Formatter.FormatNumber(1.1)); // Double: 1.1
Console.WriteLine(Formatter.FormatMessage("Hello")); // Hello
Console.WriteLine(Formatter.FormatMessage("Hello", 3)); // HelloHelloHello
