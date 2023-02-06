Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

bool bit3 = (number & 4) != 0 ;
Console.WriteLine($"Bit 3 is 1: {bit3}");

