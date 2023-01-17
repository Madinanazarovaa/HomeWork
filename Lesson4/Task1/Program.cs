// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Numbers()
{
    System.Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

double Degree(int a, int b)
{
    double degree = 0;
    for(int i = 0; b >= i; i++)   
    {
    degree = Math.Pow(a,b);
    }  
    return degree;
}

int a = Numbers();
int b = Numbers();
double result = Degree(a,b);
Console.WriteLine(result);