int a = new Random().Next(10,10000);
int b = 0;
int c = 0;
System.Console.WriteLine(a);

{
    if
    (a >= 10000)
    {
        b = a % 1000;
        c = b / 100;
        System.Console.WriteLine(c);
    }

    else if
    (a >= 1000)
    {
        b = a % 100;
        c = b / 10;
        System.Console.WriteLine(c);
    }

    else if
    (a >= 100)
    {
        b = a % 100;
        c = b % 10;
        System.Console.WriteLine(c);
    }

    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
}