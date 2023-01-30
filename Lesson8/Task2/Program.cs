// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArrayRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Sum(int[,] array, int[] arr)
{
    int i = 0;
    int sum = 0;
    for(; i < array.GetLength(0);)
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if(j == array.GetLength(1) - 1)
            { 
                arr[i] = sum;
                System.Console.Write(arr[i] + " ");
                sum = 0;
                i++;
            }

        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();

}

void FindStringWithMinSum(int[] arr)
{
    int i = 0;
    int index = 0;
    int min = arr[i];
    for(; i < arr.Length; i++)
    {
        if(min >= arr[i])
        {
            min = arr[i];
            index = i + 1;
        }
    }
    System.Console.WriteLine($"{index} строка");
}


int lines = 4;
int columns = 4;
int[,] array = new int[lines, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
int[] arr = new int[lines];
Sum(array, arr);
FindStringWithMinSum(arr);



