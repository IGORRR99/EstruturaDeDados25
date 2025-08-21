Console.Write("Enter the length of the Fibonacci Series: ");
int length = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    Console.Write(" {0} ", FibonacciSeries(1));
}
Console.ReadKey();

static int FibonacciSeries(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
}
