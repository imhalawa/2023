Console.Write("N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("P: ");
int p = int.Parse(Console.ReadLine());

Console.Write("V: ");
int v = int.Parse(Console.ReadLine());

int mask = v << p;
int result = n ^ mask;

System.Console.WriteLine("Result {0}", result);