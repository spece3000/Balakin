Console.WriteLine("введите надежный пароль");
string password = Console.ReadLine();
bool prov1 = true;
bool prov2 = true;
bool prov3 = true;
char[] special = { '$', '@', '#', '%', '*', '!' };

for (int i = 0; i < password.Length; i++)
{
    if (char.IsUpper(password[i]))
    {
        prov1 = false;
    }
}
foreach (char c in password)
{
    if (char.IsDigit(c))
    {
        prov2 = false;
    }
}
for(int i = 0; i < password.Length; i++)
{
    for(int j = 0; j < special.Length; j++)
    {
        if (special[j] == password[i])
        {
            prov3 = false;
        }
    }
}

if (password.Length < 8)
{
    Console.WriteLine("ненадежный пароль, длина должна быть не менее 8 символов");
}
if (prov1)
{
    Console.WriteLine("ненадежный пароль, должна быть большая буква");
}
if (prov2)
{
    Console.WriteLine("ненадежный пароль, должна быть цифра");
}
if (prov3)
{
    Console.WriteLine("ненадежный пароль, должен быть спецсимвол");
}


Console.WriteLine("введите нечетное число");
int romb = Convert.ToInt32(Console.ReadLine());
int probel = romb / 2;
int zvezd = 1;
int zvezd2 = 0;
int probel2 = 0;

for (int i = 0; i < romb; i++)
{
    if (probel >= 0)
    {
        for (int j = 0; j < probel; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < zvezd; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        probel--;
        zvezd += 2;
        zvezd2 = zvezd - 2;
    }
    else
    {
        zvezd2 -= 2;
        probel2++;
        for (int j = 0; j < probel2; j++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < zvezd2; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("загадал случайное число от 1 до 100, попробуй угадать");
int random = Random.Shared.Next(1, 101);
int vvod = -1;
bool game = true;
int pop = 0;

while(game)
{
    vvod = Convert.ToInt32(Console.ReadLine());
    if (vvod < 101 && vvod > 0)
    {
        if (vvod < random)
        {
            Console.WriteLine("больше");
            pop++;
        }
        else if (vvod > random)
        {
            Console.WriteLine("меньше");
            pop++;
        }
        else if (vvod == random)
        {
            pop++;
            Console.WriteLine("угадал с " + pop + " попытки");
            Console.WriteLine("хочешь сыграть ещё раз, да или нет");
            string what = Console.ReadLine();
            if (what == "да")
            {
                Console.WriteLine("загадал случайное число от 1 до 100, попробуй угадать");
                pop = 0;
                random = Random.Shared.Next(1, 101);
            }
            else if (what == "нет")
            {
                game = false;
            }
        }
    }
    else
    {
        Console.WriteLine("от 1 до 100, у тебя не то число");
    }
}