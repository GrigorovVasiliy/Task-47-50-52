Console.Write("Введите размер матрицы через пробел, где первое число строки, второе столбцы: ");
int[] size = Console.ReadLine().Split(" ").Select(x=> int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
ImputMatrix(matrix);

void ImputMatrix(double[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().NextDouble()*(10-(-11)-(-11));
            //(Math.Round(matrix[i, j], 2)); 
            Console.Write($"{Math.Round(matrix[i, j],1)} \t"); 
        }
        Console.WriteLine(); 
    }
}