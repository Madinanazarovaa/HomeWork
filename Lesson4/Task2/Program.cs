// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Number()
{
    System.Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers()
{
    int sum = 0;
    int number = (Number());
    while (number > 0)
    {
        sum += (number % 10); 
        number = number / 10;
    }

    return sum;
}

int sum = SumNumbers();
Console.WriteLine(sum);

