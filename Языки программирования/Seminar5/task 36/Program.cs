// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

void FillAndPrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 101);
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[length];
FillAndPrintArray(numbers);
Console.WriteLine();

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 != 0) sum += numbers[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum}");