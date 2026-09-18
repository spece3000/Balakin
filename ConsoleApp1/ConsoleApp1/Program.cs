int a = Convert.ToByte(Console.ReadLine(), 2);
Console.WriteLine(a);

Console.WriteLine();

int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(b, 2));

Console.WriteLine();

int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
int T = Convert.ToInt32(Console.ReadLine());
while(T > 60)
{
    T -= 60;
    N++;
}
int min = M + T;
if (min >= 60)
{
    min -= 60;
    N++;
}
while (N >= 24)
{
    N -= 24;
}
if (min < 10)
{
    Console.WriteLine(N + ":0" + min);
}
else
{
    Console.WriteLine(N + ":" + min);
}