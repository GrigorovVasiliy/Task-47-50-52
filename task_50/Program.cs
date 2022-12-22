Console.Write("Введите позицию строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[7, 7];
ImputMatrix(matrix);

void ImputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
if (a < matrix.GetLength(0) && b < matrix.GetLength(1)) 
Console.WriteLine($"Позиции со стракой {a} и столбом {b} -> {matrix[a,b]}.");
else 
Console.WriteLine($"Позиции со стракой {a} и столбцом {b} -> в массиве нет");