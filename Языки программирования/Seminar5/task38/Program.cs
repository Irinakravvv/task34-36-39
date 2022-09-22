// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillAndPrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(0, 100);
        arr[i] = Math.Round(new Random().NextDouble() * num, 2);
        Console.Write($"{arr[i]} ");
    }
}

Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[length];

FillAndPrintArray(numbers);
Console.WriteLine();

double maxNumber = numbers[0];
double minNumber = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > maxNumber) maxNumber = numbers[i];
    else if (numbers[i] < minNumber) minNumber = numbers[i];
}
Console.WriteLine($"Максимальный элемент равен {maxNumber}. Минимальный элемент равен {minNumber}. Разность равна {maxNumber - minNumber}");

