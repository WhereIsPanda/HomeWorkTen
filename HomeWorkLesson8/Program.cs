//Zadacha54();
//Zadacha56();
Zadacha58();

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

void Zadacha54()
{
    int rows = 4;
    int columns = 5;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("отсортированный массив:");
    
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1 - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    PrintArray(array);
    
    }





void FillArray(int[,] array)
{
    {
            Random random = new Random();
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }

        }
}




void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
      for (int j = 0; j < columns; j++)
      {
          Console.Write(array[i, j] + "\t");
      }
      Console.WriteLine();
  }  
}




// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    int rows = 4;
    int columns = 5;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    int sumMinIndex = 0;
    




    int minSum = 0;
    for (int j = 0; j < columns; j++)
    {
      minSum += array[0, j];
    }
    Console.WriteLine($"Сумма первой строки равна {minSum}");
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма чисел: {sum}, в строке {i+1}");
        if (sum < minSum)
        {
            minSum = sum;
            sumMinIndex = i;
            
        }
        
    }
    Console.WriteLine($"Минимальная сумма находится в строке {sumMinIndex} {minSum}");
}

//Заполните спирально массив 4 на 4.

void Zadacha58()
{
    int rows = 6;
    int columns = 6;
    int[,] array = new int[rows, columns];
    int indexI = 0;
    int indexJ = 0;
    int changeI = 0;
    int changeJ = 1;
    int Step = columns;
    int turn = 0;
    for (int i = 1; i < array.Length + 1; i++)
    {
        array[indexI, indexJ] = i;
        
        Step --;
        if (Step == 0)
        {
           Step = columns * (turn%2) + rows * ((turn + 1)%2) - 1 - turn/2;
           int temp = changeI;
           changeI = changeJ;
           changeJ = -temp;
           turn ++;
        }
        
        indexI += changeI;
        indexJ += changeJ;
    }
Console.WriteLine();
PrintArray(array);
}
