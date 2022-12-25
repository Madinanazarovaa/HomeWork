System.Console.WriteLine("Напишите цифру обозначающую день недели, чтобы проверить, является этот день выходным");
int number = Convert.ToInt32(Console.ReadLine());

{
    if
    (number > 7)
    {
        System.Console.WriteLine("Напишите цифру обозначающую день недели");
    }

    else if 
    (number == 0)
    {
        System.Console.WriteLine("Напишите цифру обозначающую день недели");
    }
    
    else if
    (number <= 5)
    {
        System.Console.WriteLine("Нет");
    }

    else
    {
        System.Console.WriteLine("Да");
    }
}