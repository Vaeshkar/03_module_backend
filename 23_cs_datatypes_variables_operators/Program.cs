// 1. Declarations and Literals
int number = 47;
long bigNumber = 1234567890123456789;
float tempFloat = 35.6F;
double tempDouble = 26.45D;

Console.WriteLine("Declarations and Literals");
Console.WriteLine(number);
Console.WriteLine(bigNumber);
Console.WriteLine(tempFloat);
Console.WriteLine(tempDouble);
Console.WriteLine(" "); // empty line

// 2. Arithmetic and Interger Division
Console.WriteLine("Arithmetic and Interger Division");
int a = 10;
int b = 3;
int c = a / b;
Console.WriteLine(c);
int d = a * b;
Console.WriteLine(d);
int e = a + b;
Console.WriteLine(e);
int f = a - b;
Console.WriteLine(f);
int g = a % b;
Console.WriteLine(g);
Console.WriteLine(" "); // empty line

// Comparison and Logical Operations
Console.WriteLine("Comparison and Logical Operations");
int h = 10;
int i = 20;
bool j = h > g; // greater than
Console.WriteLine(i);
bool k = h < g; // less than
Console.WriteLine(j);
bool l = h >= g; // greater than or equal to
Console.WriteLine(k);
bool m = h <= g; // less than or equal to
Console.WriteLine(l);
bool n = h == g; // equal to
Console.WriteLine(m);
bool o = h != g;  // not equal to
Console.WriteLine(n);
bool p = (h != 0) && (g != 0); // logical AND
Console.WriteLine(o);
bool q = (h != 0) || (g != 0); // logical OR
Console.WriteLine(p);
bool r = !(h != 0); // logical NOT
Console.WriteLine(q);
Console.WriteLine(" "); // empty line

// Scientific Notation
Console.WriteLine("Scientific Notation");
double distanceSun = 1.496E8; // 1.496 * 10^8
Console.WriteLine(distanceSun);
Console.WriteLine(" "); // empty line
double electricMass = 9.109E-31; // 9.109 * 10^-31
Console.WriteLine(electricMass);
Console.WriteLine(" "); // empty line

// Operator precedence
Console.WriteLine("Operator precedence");
int result1 = 2 + 3 * 4; // difference 14
Console.WriteLine(result1);
int result2 = (2 + 3) * 4; // difference 20
Console.WriteLine(result2);
Console.WriteLine(" "); // empty line

// Compount assignment and increment
Console.WriteLine("Compount assignment and increment");
int counter = 0;
counter += 2; // counter = counter + 2
Console.WriteLine(counter);
counter++; // counter = counter + 1
Console.WriteLine(counter);
counter -= 1; // counter = counter - 1
Console.WriteLine(counter);
counter--; // counter = counter - 1
Console.WriteLine(counter);
counter /= 1; // counter = counter / 1
Console.WriteLine(counter);
Console.WriteLine(" "); // empty line

// Conversions (casts) and rouding
Console.WriteLine("Conversions (casts) and rouding");
double score = 7.85D;
int truncated = (int)score; // 7
Console.WriteLine(truncated);
double rounded = Math.Round(score, 1); // 7.9
Console.WriteLine(rounded);
float scoreF = (float)score; // 7.85
Console.WriteLine(scoreF);
Console.WriteLine(" "); // empty line

// Overflow check
Console.WriteLine("Overflow check");
Console.WriteLine("Analyse the difference between checked and unchecked context");
// Analyse the difference between checked and unchecked context
// Anwser: checked context throws an exception, unchecked context wraps around, like a clock.
try
{
  checked
  {
    int max = int.MaxValue;
    Console.WriteLine($"Max int: {max}");
    // The next line will throw OverflowException if executed in checked context
    int boom = max + 1;
    Console.WriteLine($"This will not print (boom={boom})");
  }
}
catch (OverflowException)
{
  Console.WriteLine("Overflow caught in checked context");
}

unchecked
{
    int max = int.MaxValue;
    int wrapped = max + 1; // wraps to negative in unchecked context
    Console.WriteLine($"Unchecked wrap-around result: {wrapped}");
}

// Floats vs double precision
Console.WriteLine("Floats vs double precision");
float numberFloat = 0.1F + 0.2F; // 0.300000011920929
Console.WriteLine(numberFloat);
double numberDouble = 0.1D + 0.2D; // 0.3
Console.WriteLine(numberDouble);
Console.WriteLine(" "); // empty line
// Print both and compare them with ==.
// Add a comment about rounding errors and why double usually gives better precision than float.
Console.WriteLine("Compare float and double");
Console.WriteLine(" "); // empty line
bool compare = numberFloat == numberDouble; // false
Console.WriteLine(compare);
Console.WriteLine(" "); // empty line

// Mini Challenge
double weightKG = 110;
double heightM = 1.82;
double bmi = weightKG / (heightM * heightM);
// add a tanery with "normal" and "not normal"
string bmiStatus = bmi < 18.5 ? "Underweight" : bmi < 25 ? "Normal" : bmi < 30 ? "Overweight" : "Obese";
Console.WriteLine(bmiStatus);
Console.WriteLine(" "); // empty line
