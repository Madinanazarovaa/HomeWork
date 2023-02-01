// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void OutputOfNaturalNumbers(int number)
{
    System.Console.Write(number + " ");
    if (number == 1)
    {
        return;
    }
    number--;
    OutputOfNaturalNumbers(number);
}

OutputOfNaturalNumbers(8);