// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] newMatrix = RandomArray(5, 5);
PrintArray(newMatrix);
Console.WriteLine();
PrintArray(OrderingMatrix(newMatrix));

int[,] OrderingMatrix(int[,] matrix)
{
    int[,] FindMaxInMatrix (int[,] matrix, int i)
    {
        int x = 0;
        for (int j = matrix.GetLength(1) - 2; j >= 0; j--)
        {
            x = matrix[i,j];
            if (matrix[i, j + 1] > x) 
            {
                matrix[i,j] = matrix[i, j + 1];
                matrix[i, j + 1] = x;
            }
        }
        return matrix;
    }
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix = FindMaxInMatrix(matrix, i);
        }
    }
    return matrix;
}

int[,] RandomArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = randGenerator.Next(0, 10);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]} ");
        Console.WriteLine("");
    }
}