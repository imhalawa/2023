const double moonToEarthGravity = 0.17;
Console.Write("Weight: ");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine($"Weight on moon = {weight} * {moonToEarthGravity} = {(weight * moonToEarthGravity):0.00}");