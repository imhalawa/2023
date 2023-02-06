Console.Write("X: ");
double X = double.Parse(Console.ReadLine());

Console.Write("Y: ");
double Y = double.Parse(Console.ReadLine());

bool withinCircle = (X <= 5 && X >= -5) && (Y >= -5 && Y <= 5);
bool outOfRectangle = (X < -1 && Y < 1);

Console.WriteLine($"Point ({X},{Y}) is {(withinCircle&& outOfRectangle ? "" : "not")} within the circle and out of rectangle!");