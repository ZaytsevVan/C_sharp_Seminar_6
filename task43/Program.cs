// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// {y = k1 * x + b1 --> {0 = k1 * x + b1 - k2 * x - b2 --> {-k1 * x + k2 * x = b1 - b2 --> {x = (b1 - b2) / (-k1 + k2)
// {y = k2 * x + b2     {y = k2 * x + b2                   {y = k2 * x + b2               {y = k2 * x + b2 

double B1()
{
    Console.WriteLine("Введите значение b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    return b1;
}

double K1()
{
    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    return k1;
}

double B2()
{
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    return b2;
}

double K2()
{
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    return k2;
}

double CoordinatesXOfTheIntersectionOfStraightLines(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (-k1 + k2);
    return x;
}

double CoordinatesYOfTheIntersectionOfStraightLines(double b2, double k2, double x)
{
    double y = k2 * x + b2;
    return y;
}

double b1 = B1();
double k1 = K1();
double b2 = B2();
double k2 = K2();
double x = CoordinatesXOfTheIntersectionOfStraightLines(b1, k1, b2, k2);
double y = CoordinatesYOfTheIntersectionOfStraightLines(b2, k2, x);

Console.WriteLine($"({x}, {y})");

// Мне кажется, что это задание лучше решить с аргументами out перед некоторыми переменными,
// но к сожалению, не успел разобраться как.