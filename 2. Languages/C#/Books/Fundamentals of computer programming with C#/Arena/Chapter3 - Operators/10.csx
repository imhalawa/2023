Console.WriteLine("Enter a 4 digit number: ");
int input = int.Parse(Console.ReadLine());

int r1 = input % 1000, r2 = input % 100, r3 = input % 10;

int d1 = input / 1000;
int d2 = r1 / 1000;
int d3 = r2 / 10;
int d4 = r3;


// Sum of the 4 digits 
System.Console.WriteLine(d1+d2+d3+d4);

// Reverse
System.Console.WriteLine($"{d4}{d3}{d2}{d1}");

// dabc
System.Console.WriteLine($"{d4}{d1}{d2}{d3}");

// acbd
System.Console.WriteLine($"{d1}{d3}{d2}{d4}");
