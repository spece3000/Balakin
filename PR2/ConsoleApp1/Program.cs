Console.WriteLine("что вам надо решить, квадратное или обычное, введите нужное");
string what = Console.ReadLine();

if (what == "обычное")
{
    double num1 = Convert.ToDouble(Console.ReadLine());
    string sign = Console.ReadLine();
    double num2 = Convert.ToDouble(Console.ReadLine());
    double answer = 0;

    switch (sign)
    {
        case "+":
            answer = num1 + num2;
            break;
        case "-":
            answer = num1 - num2;
            break;
        case "*":
            answer = num1 * num2;
            break;
        case "/":
            answer = num1 / num2;
            break;
        case "%":
            answer = num1 % num2;
            break;
        case "^":
            answer = Math.Pow(num1, num2);
            break;
        case "корень":
            answer = Math.Pow(num1, 1 / num2);
            break;
        default: 
            answer = 0;
            break;
    }
    Console.WriteLine(answer);
}
else if(what == "квадратное"){
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    double D = b * b - 4 * a * c;
    if (D > 0)
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine("x1 равен " + x1);
        Console.WriteLine("x2 равен " + x2);
    }
    else if (D == 0)
    {
        double x = -b / (2 * a);
        Console.WriteLine("x равен " + x);
    }
    else if(D < 0)
    {
        Console.WriteLine("корней нет");
    }
    else
    {
        Console.WriteLine("это вообще как");
    }
}
else
{
    Console.WriteLine("такого нет");
}