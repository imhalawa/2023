namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual(3.0000051, 3.00000061));
        }

        static bool AreEqual(double a, double b)
        {
            // Two floating-point variables are considered equal if their difference is less  than some predefined precision
            return Math.Abs(a - b) > 0.000001;
        }
    }
}