// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Прогрмма считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine($"Суммы всех строк: {String.Join(" ", SumStringResult(array))}");
System.Console.WriteLine();
NumberStringMinimumSum(SumStringResult(array));



// ------------------Method----------------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] =new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
                Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}



int[] SumStringResult(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = i; k < array.GetLength(0); k++)
        {
            int result = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
            sumArray[k] = result;
        }
    }
    return sumArray;
}

void NumberStringMinimumSum(int[] array)
{
    int min = array[0];
    int result = 1;
    for(int i = 1; i < array.Length; i++)
    {
        
        if(array[i] < min)
        {
            min = array[i];
            result = i + 1;
        }
    }
    System.Console.WriteLine($"Строка {result} имеет наименьшую сумму равную {min}");
}