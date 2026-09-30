Console.WriteLine("Введите предложение");
string predl = Console.ReadLine();
Console.WriteLine("Введите разделитель");
char razdel = Convert.ToChar(Console.ReadLine());

string[] split_predl = predl.Split(razdel);

foreach (string s in split_predl)
{
    Console.WriteLine(s);
}


Console.WriteLine("Введите предложение");
string s1  = Console.ReadLine();
Console.WriteLine("Введите что искать");
char ch1  = Convert.ToChar(Console.ReadLine());
int schet = 0;

for(int i = 0; i < s1.Length; i++)
{
    if ((char)s1[i] == ch1)
    {
        schet++;
    }
}

string s2 = s1.Replace(ch1, char.ToUpper(ch1));

Console.WriteLine(schet);
Console.WriteLine(s2);


Console.WriteLine("Введите предложение");
string s3 = Console.ReadLine();
Console.WriteLine("Вам нужен шифратор или дешифратор");
string what = Console.ReadLine();
Console.WriteLine("Введите на сколько");
int cesor = Convert.ToInt32(Console.ReadLine());
char[] vse = new char[s3.Length];

for (int i = 0; i < s3.Length; i++)
{
    if (what == "шифратор")
    {
        vse[i] = (char)(s3[i] + cesor);
    }
    else if (what == "дешифратор")
    {
        vse[i] = (char)(s3[i] - cesor);
    }
    Console.Write(vse[i]);
}