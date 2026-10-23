Console.WriteLine("введи число ");
int a = Convert.ToInt32(Console.ReadLine());
int summ(int a)
{
    if (a < 10) return a;
    return a % 10 + summ(a / 10);
}
Console.WriteLine(summ(a));


Console.WriteLine("введи два числа ");
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int NOD(int a, int b)
{
    if (a % b == 0) return b;
    return NOD(b, a % b);
}
Console.WriteLine(NOD(b, c));

Console.WriteLine("введи число колец");
int n = Convert.ToInt32(Console.ReadLine()); 

void bashny(int n, char from, char to, char dop)
{
    if (n == 1)
    {
        Console.WriteLine($"кольцо 1: {from} на {to}");
        return;
    }
    bashny(n - 1, from, dop, to);
    Console.WriteLine($"кольцо {n}: {from} на {to}");
    bashny(n - 1, dop, to, from);
}

bashny(n, 'A', 'B', 'C');