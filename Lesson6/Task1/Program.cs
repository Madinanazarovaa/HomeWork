// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArray(int[] array)
{
    System.Console.WriteLine($"Введите {array.Length} чисел");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

string GetArrayInString(int[] array)
{
    return String.Join(", ", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int CheckArray(int[] array)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            j++;
        }
    }

    return j;
}

int size = 5;
int[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
int chek = CheckArray(array);
System.Console.WriteLine(chek);