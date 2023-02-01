// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int NumberM()
{
    System.Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    return m;
}

int NumberN()
{
    System.Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

void SumOfNaturalNumbers(int sum, int m, int n)
{
    if(n < m)
    {
        System.Console.WriteLine("Число M должно быть меньше числа N");
        return;
    }

    {
        sum = sum + m;
        if(m == n)
        {   
            System.Console.WriteLine("Сумма натуральных чисел от M до N = " + sum);
            return;
        }
        m++;
        SumOfNaturalNumbers(sum, m, n);
    }
}

int m = NumberM();
int n = NumberN();
SumOfNaturalNumbers(0, m, n);