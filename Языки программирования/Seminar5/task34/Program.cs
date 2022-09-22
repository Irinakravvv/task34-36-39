// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 // которая покажет количество чётных чисел в массиве.




void FillAndPrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next (100, 1000);
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[length];
FillAndPrintArray(numbers);
Console.WriteLine();

int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) count += 1;
}
Console.WriteLine($"В массиве {count} четных чисел");