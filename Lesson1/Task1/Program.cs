
System.Console.WriteLine("Напишите два числа, чтобы программа сравнила их и выдала max и min");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

{
    if
    (number1 > number2)
    {
        System.Console.WriteLine("max " + number1);
        System.Console.WriteLine("min " + number2);
    }

    else if
    (number1 < number2)
    {
        System.Console.WriteLine("max " + number2);
        System.Console.WriteLine("min " + number1);
    }
}