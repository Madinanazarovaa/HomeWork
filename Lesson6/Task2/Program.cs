// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double InteringValues(string msg)
{
    Console.WriteLine(msg);
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (Math.Abs(k1 - k2));
    return x;
}

double FindY(double x, double b2, double k2)
{
    double y = k2 * x + b2;
    return y;
}

void Conclusion(double b1, double k1, double b2, double k2, double x, double y)
{
    if ( k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые парралельны - не пересекаются.");
    }

    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые имеют множество точек пересечения.");
    }

    if (k1 != k2 && b1 != b2)
    {
        Console.WriteLine($"Точка пересечения: {x}; {y}");
    }
}

double b1 = InteringValues(msg:"Введите b1");
double k1 = InteringValues(msg:"Введите k1");
double b2 = InteringValues(msg:"Введите b2");
double k2 = InteringValues(msg:"Введите k2");
double x = FindX(b1, k1, b2, k2);
double y = FindY(x, b2, k2);
Conclusion(b1, k1, b2, k2, x, y);