using System.Numerics;

Console.WriteLine("введите сколько переменных содержит массив");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];

Console.WriteLine("введите переменные которые содержит массив");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();


Console.WriteLine("введите сколько переменных содержит массив 2");
int b = Convert.ToInt32(Console.ReadLine());
int[] array_2 = new int[b];
int c = 1;

Console.WriteLine("введите переменные которые содержит массив 2");
for (int i = 0; i < array_2.Length; i++)
{
    if (i % 2 == 0)
    {
        array_2[^c] = Convert.ToInt32(Console.ReadLine());
    }
    else if (i % 2 == 1)
    {
        array_2[c - 1] = Convert.ToInt32(Console.ReadLine());
        c++;
    }
}
for (int i = 0; i < array_2.Length; i++)
{
    Console.Write(array_2[i] + " ");
}
Console.WriteLine();


Console.WriteLine("двумерный массив");
int[,] arr = new int[10, 10];
int[] plus = new int[10];
int[] umn = new int[10] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
int max_plus = 0;
int max_umn = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Random.Shared.Next(0, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("складывание строк: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        plus[i] = plus[i] + arr[i, j];
    }
    Console.Write(plus[i] + " ");
}
Console.WriteLine();
Console.Write("умножение столбцов: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        umn[i] = umn[i] * arr[j, i];
    }
    Console.Write(umn[i] + " ");
}
Console.WriteLine();
Console.Write("самое большое складывание: ");
for (int i = 0; i < plus.Length; i++)
{
    if (max_plus < plus[i])
    {
        max_plus = plus[i];
    }
}
Console.Write(max_plus);
Console.WriteLine();
Console.Write("самое большое умножение: ");
for (int i = 0; i < umn.Length; i++)
{
    if (max_umn < umn[i])
    {
        max_umn = umn[i];
    }
}
Console.Write(max_umn);