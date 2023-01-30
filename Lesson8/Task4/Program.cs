// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

void FillArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a,b,c] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write($"{array[a,b,c]} ({a} {b} {c}) {" "}");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);