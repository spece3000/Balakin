int prov = 15;

Console.WriteLine("вывод do while");
do
{
    prov += prov;
    Console.WriteLine( prov );
} while ( prov < 15 );

prov = 15;

Console.WriteLine("вывод while");
while ( prov < 15)
{
    prov += prov;
    Console.WriteLine( prov );
}

Console.WriteLine("введите число i");
int i = Convert.ToInt32(Console.ReadLine());
int j = 1;

while ( j < i )
{
    Console.WriteLine(j);
    j = j * 2;
}

Console.WriteLine("введите сколько чисел должно быть в ряду Фибоначи, минимум 2");
int what = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
Console.Write(a + " " + b);

while (what >= 0)
{
    int next = a + b;
    Console.Write(" " + next);
    a = b;
    b = next;
    what--;
}
