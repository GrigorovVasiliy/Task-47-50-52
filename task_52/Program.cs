Console.Write("Введите размер матрицы через пробел, где первое число строки, второе столбцы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
ImputMatrix(matrix);

Console.WriteLine($"Средняя арифметическая элементов каждого столбца.");
void ImputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    { sum += matrix[j, i]; }
    Console.Write($"{string.Join(", ", sum / size[1])} \t");
}