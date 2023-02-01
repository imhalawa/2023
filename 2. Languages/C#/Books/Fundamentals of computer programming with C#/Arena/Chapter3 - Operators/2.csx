Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
bool isDivisableBy5And7 = number % (5*7) == 0;
Console.WriteLine($"Is Divisable by 5 and 7: {isDivisableBy5And7}");
