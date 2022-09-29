// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет


Console.Clear();

void FillMatrix(int[,] matrix)            
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 101);
        }
    }
}

void PrintMatrix(int[,] matrix)                           
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}

int FindInMatrix(int[,] matrix, int row, int col)          
{
    if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1)) return matrix[row, col];
    else
    {
        Console.WriteLine("Указанного элемента не существует");
        return -1;
    }
}

Console.WriteLine("Задайте количество строк массива");      
int rows = Convert.ToInt32(Console.ReadLine());
    

Console.WriteLine("Задайте количество столбцов массива");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, cols];
FillMatrix(numbers);

PrintMatrix(numbers);                                      

Console.WriteLine("Укажите позицию искомого элемента");     
Console.Write("Строка: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец: ");
int numberCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindInMatrix(numbers, numRow, numCol));


