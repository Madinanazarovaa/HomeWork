// // // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArrayRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

int[,] BubbleSort(int[,] array)
{
    for (int a = 1; a < array.GetLength(0); a++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - a; j++)
            {
                if(array[i,0] < array[i,3])
                {
                    Swap(ref array[i,3], ref array[i,0]);
                }

                if (array[i,j] < array[i,j + 1])
                {
                    Swap(ref array[i,j], ref array[i,j + 1]);
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int lines = 3;
int columns = 4;
int[,] array = new int[lines, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
PrintArray(BubbleSort(array));
