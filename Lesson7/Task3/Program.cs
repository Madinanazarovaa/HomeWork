// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Average(int[,] array)
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1);)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            if (i == array.GetLength(0) - 1)
            {
                average = sum / array.GetLength(0);
                System.Console.Write(average + ", ");
                j++;
                sum = 0;
            }
        }

    } 
}

int lines = 4;
int columns = 6;
int[,] array = new int[lines, columns];
FillArray(array);
PrintArray(array);
Average(array);