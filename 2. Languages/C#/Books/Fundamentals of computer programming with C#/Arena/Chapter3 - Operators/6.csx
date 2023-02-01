Console.Write("Height: ");
int height = int.Parse(Console.ReadLine());

Console.Write("Width: ");
int width = int.Parse(Console.ReadLine());

Console.WriteLine($"Perimeter = {(height + width) * 2}");
Console.WriteLine($"Area = {height * width}");