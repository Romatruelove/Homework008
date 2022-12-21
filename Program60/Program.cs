Console.WriteLine("Первый размер массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второй размер массива:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третий размер массива:");
int c = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[a, b, c];

void FillArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                array[a, b, c] = new Random().Next(10, 100);
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write($"{array[a, b, c]}({a},{b},{c})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine();
FillArray(array);
PrintArray(array);