// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = 14241;
int number1 = number / 10000;
int number2 = (number / 1000) % 10;
int number4 = (number / 10) % 10;
int number5 = (number % 10);

if 
(number1 == number5 && number2 == number4)
{
    System.Console.WriteLine($"{number} Да");
}

else
{
    System.Console.WriteLine($"{number} Нет");
}