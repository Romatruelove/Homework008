Console.WriteLine("Введите количество строк m для первой матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n для первой матрицы (будет равно количеству строк второй матрицы):");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов p для второй матрицы:");
int p = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, p];
int[,] matrix3 = new int[m, p];

void FillMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix1.GetLength(1); j++)
            matrix1[i, j] = new Random().Next(0, 10);
}
void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            Console.Write($"{matrix1[i, j]}\t");
        Console.WriteLine();
    }
}

void FillMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = new Random().Next(0, 10);
}
void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
            Console.Write($"{matrix2[i, j]}\t");
        Console.WriteLine();
    }
}
void DevMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      matrix3[i,j] = sum;
      Console.Write($"{matrix3[i, j]}\t");
    }
    Console.WriteLine();
  }
}

FillMatrix1(matrix1);
FillMatrix2(matrix2);
Console.WriteLine();
PrintMatrix1(matrix1);
Console.WriteLine();
PrintMatrix2(matrix2);
Console.WriteLine("Произведение двух матриц:");
DevMatrix(matrix1, matrix2, matrix3);