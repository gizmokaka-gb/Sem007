// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
FillArrayRandomNumbers(matrix);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

for (int i = 0; i < columns; i++)
{
    double sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum += matrix[j, i];
    }
    Console.WriteLine($"Среднее арифметическое в {i} столбце: {sum / columns}");
}