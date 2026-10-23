public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction()
    {
        _numerator = 0;
        _denominator = 1;
    }

    public Fraction Add(Fraction other)
    {
        return new Fraction(
            _numerator * other._denominator + other._numerator * _denominator,
            _denominator * other._denominator
        );
    }

    public Fraction Add(int number)
    { return Add(new Fraction(number)); }

    public Fraction Add(double number)
    { return Add((int)number); }

    public static Fraction Add(Fraction a, Fraction b)
    { return a.Add(b); }

    public override string ToString()
    { return _numerator + "/" + _denominator; }
}

public class Vector2D
{
    public double X { get; }
    public double Y { get; }

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Length => System.Math.Sqrt(X * X + Y * Y);
    public override string ToString() => $"({X}; {Y})";

    public static Vector2D operator +(Vector2D a, Vector2D b) => new Vector2D(a.X + b.X, a.Y + b.Y);
    public static Vector2D operator -(Vector2D a, Vector2D b) => new Vector2D(a.X - b.X, a.Y - b.Y);
    public static Vector2D operator *(Vector2D v, double k) => new Vector2D(v.X * k, v.Y * k);
    public static Vector2D operator *(double k, Vector2D v) => new Vector2D(v.X * k, v.Y * k);
    public static double operator *(Vector2D a, Vector2D b) => a.X * b.X + a.Y * b.Y;

    public static Vector2D operator -(Vector2D v) => new Vector2D(-v.X, -v.Y);
    public static Vector2D operator ++(Vector2D v) => new Vector2D(v.X + 1, v.Y + 1);
    public static Vector2D operator --(Vector2D v) => new Vector2D(v.X - 1, v.Y - 1);

    public static bool operator ==(Vector2D a, Vector2D b) => a.X == b.X && a.Y == b.Y;
    public static bool operator !=(Vector2D a, Vector2D b) => !(a == b);
    public static bool operator <(Vector2D a, Vector2D b) => a.Length < b.Length;
    public static bool operator >(Vector2D a, Vector2D b) => a.Length > b.Length;
    public static bool operator <=(Vector2D a, Vector2D b) => a.Length <= b.Length;
    public static bool operator >=(Vector2D a, Vector2D b) => a.Length >= b.Length;
}

public class Temperature
{
    public double Celsius { get; }

    public Temperature(double celsius)
    {
        Celsius = celsius;
    }

    public double Fahrenheit => Celsius * 9 / 5 + 32;
    public double Kelvin => Celsius + 273.15;

    public override string ToString() => $"{Celsius:F2} °C";

    public static implicit operator Temperature(double celsius) => new Temperature(celsius);
    public static explicit operator double(Temperature t) => t.Celsius;
    public static explicit operator string(Temperature t) => t.ToString();
    public static explicit operator Temperature(string s) => new Temperature(double.Parse(s));
}