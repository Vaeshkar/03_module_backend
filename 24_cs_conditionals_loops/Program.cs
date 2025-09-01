using System;
// ask the user for a grade while using a switch
Console.WriteLine("Make a switch and as the user for their grade.");
Console.WriteLine("What grade did you get?");
string Grade = Console.ReadLine();
switch (Grade)
{
  case "A":
    Console.WriteLine("Excellent");
    break;
  case "B":
    Console.WriteLine("Good");
    break;
  case "C":
    Console.WriteLine("Average");
    break;
  case "D":
    Console.WriteLine("Fail");
    break;
  default:
    Console.WriteLine("Invalid Grade");
    break;
}

Console.WriteLine(" "); // Emptyline

// while loop, 1 to 100
Console.WriteLine("Do a While loop and count to 100.");
int number = 1;
while (number < 100)
{
  Console.WriteLine(number);
  number++;
}

Console.WriteLine(" "); // Emptyline

// Do While loop, guessing game: pick a random number from 1 to 10 and ask the user to guess the number. The game lets you try 5 times.
Console.WriteLine("Make a Do/While loop and guess the number.");
int randomNumber = new Random().Next(1, 10);
int userGuess;
int wrongGuess = 0;
do {
  Console.WriteLine("Guess the correct number between 1 and 10 (5 tries): ");
  userGuess = Convert.ToInt32(Console.ReadLine());
  if (wrongGuess == 5)
  {
    Console.WriteLine("You have reached the maximum number of tries.");
    break;
  }
  else if (userGuess == randomNumber)
  {
    Console.WriteLine("You guessed the correct number!");
    Console.WriteLine($"Congratulations! You finished the game with Tries left: {5 - wrongGuess}");
  }
  else
  {
    Console.WriteLine("Wrong number. Please try again.");
    wrongGuess++;
    Console.WriteLine($"Tries left: {5 - wrongGuess}");
  }
} while (userGuess != randomNumber);

Console.WriteLine(" "); // Emptyline

// For Loop, multiplaction table of 7, from 1x7 to 10x7
Console.WriteLine("Make a For loop and print the multiplication table of 7.");
for (int i = 1; i <= 10; i++)
{
  Console.WriteLine($"Multiplication of 7 x {i} = {7 * i}");
}

Console.WriteLine(" "); // Emptyline

Console.WriteLine("Write a For loop from 1 to 20.");


// Break and Continue, write a for loop from 1 to 20. Skip even numbers and stop at 15.
for (int i = 0; 1 <= 20; i++) {
  if (i == 15) {
    break;
  } else if (i % 2 == 0) {
    continue;
  } else {
    Console.WriteLine(i);
  }
};

Console.WriteLine(" "); // Emptyline
