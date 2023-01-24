// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ReturnValue(int[,] array)
{
    Console.WriteLine("Введите позицию эллемена");
    int i = Convert.ToInt32(Console.ReadLine());
    int j = Convert.ToInt32(Console.ReadLine());
    
    if (i >= array.GetLength(0) || j >= array.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    
    if (i < array.GetLength(0) && j < array.GetLength(1))
    {
        Console.WriteLine(array[i, j]);
    }
    
}

int lines = 4;
int columns = 6;
int[,] array = new int[lines, columns];
FillArray(array);
PrintArray(array);
ReturnValue(array);