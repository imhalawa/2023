Console.Write("X: ");
double X = double.Parse(Console.ReadLine());

Console.Write("Y: ");
double Y = double.Parse(Console.ReadLine());

bool withinCircle = (X <= 5 && X >= -5) && (Y >= -5 && Y <= 5);

Console.WriteLine($"Point ({X},{Y}) is {(withinCircle ? "" : "not")} within the circle!");