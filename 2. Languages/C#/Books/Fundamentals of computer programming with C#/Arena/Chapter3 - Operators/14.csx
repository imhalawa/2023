Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

bool isGreaterThanOne = number > 1;
bool isPrime = true;
for (int i = 2; i <= 100; i++)
{
    if (i == number)
    {
        continue;
    }
    isPrime = isPrime && !(number % i == 0);
}

Console.Write("{0} is {1} a prime number.", number, isPrime ? "" : "not");