Console.Write("N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("P: ");
int p = int.Parse(Console.ReadLine());

int i = 1;
int mask = i << p;
int result = (n & mask) != 0 ? 1 : 0;

System.Console.WriteLine("Result {0}", result);