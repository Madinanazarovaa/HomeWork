// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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

void MatrixResult(int[,] array, int[,] newArray)
{
    int a = 0;
    int b = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 2; j++)
        {
            if(i == 0 && j == 0)
            {
            a = (array[0,0] * array[0,2]) + (array[0,1] * array[1,2]);
            newArray[i, j] = a;
            System.Console.Write(newArray[i,j] + " ");
            }
            
            if(i == 0 && j == 1)
            {
            b = (array[0,0] * array[0,3]) + (array[0,1] * array[1,3]);
            newArray[i, j] = b;
            System.Console.Write(newArray[i,j] + " ");
            }
            
            if(i == 1 && j == 0)
            {
            a = (array[1,0] * array[0,2]) + (array[1,1] * array[1,2]);
            newArray[i,j] = a;
            System.Console.Write(newArray[i,j] + " ");
            }

            if(i == 1 && j == 1)
            {
            b = (array[1,0] * array[0,3]) + (array[1,1] * array[1,3]);
            newArray[i,j] = b;
            System.Console.Write(newArray[i,j] + " ");
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] array = new int[2,4];
FillArray(array);
PrintArray(array);
int[,] newArray = new int[2,2];
MatrixResult(array, newArray);