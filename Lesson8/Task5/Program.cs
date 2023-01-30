// Напишите программу, которая заполнит спирально массив 4 на 4.

void SpiralFilling(string[,] array)
{
    string n = string.Empty;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == 0)
            {   
                if(j == 0)
                {
                    n = "01";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
                
                if(j == 1)
                {
                    n = "02";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 2)
                {
                    n = "03";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 3)
                {
                    n = "04";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
            }
            
            if(i == 1)
            {
                if(j == 0)
                {
                    n = "12";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
                
                if(j == 1)
                {
                    n = "13";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 2)
                {
                    n = "14";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 3)
                {
                    n = "05";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
            }          

            if(i == 2)
            {
                if(j == 0)
                {
                    n = "11";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
                
                if(j == 1)
                {
                    n = "16";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 2)
                {
                    n = "15";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 3)
                {
                    n = "06";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

            }
                        
            if(i == 3)
            {
                if(j == 0)
                {
                    n = "10";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
                
                if(j == 1)
                {
                    n = "09";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 2)
                {
                    n = "08";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }

                if(j == 3)
                {
                    n = "07";
                    array[i, j] = n;
                    System.Console.Write(array[i, j] + " ");
                }
            }
        }
        System.Console.WriteLine();
    }

}

string[,] array = new string[4, 4];
SpiralFilling(array);