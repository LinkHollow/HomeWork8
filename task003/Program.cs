// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк первой матрицы: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы и строк второй матрицы: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetArray(rows, columns, 0, 3);

Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);

int rows2 = columns;

int[,] matrix2 = GetArray(rows2, columns2, 0, 3);
System.Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение двух матриц: ");
PrintArray(ProductTwoMatrix(matrix1, matrix2));


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

int[,] ProductTwoMatrix(int[,] array, int[,] array2)
{
    int[,] matrix = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += (array[i, k] * array2[k, j]);
            }
            matrix[i,j] = sum;
        }

    }
    return matrix;
}


