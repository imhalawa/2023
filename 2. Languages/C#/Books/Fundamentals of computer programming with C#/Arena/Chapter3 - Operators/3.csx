Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

bool isTheThirdDigitASeven = ((number / 100) % 10) == 7;
Console.WriteLine($"{isTheThirdDigitASeven}");