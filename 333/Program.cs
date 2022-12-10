// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
int[] myArray = { 236, 44, 66, 88, 34, 23, 34, 34, 34, 22 };
int minimum = myArray[0];
for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < minimum)
    {
        minimum = myArray[i];
    }
}

Console.WriteLine($"Минимальное значение массива {minimum}");

int maximum = myArray[0];
for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] > maximum)
    {
        maximum = myArray[i];
    }
}

Console.WriteLine($"Максимальное значение массива {maximum}");
Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {maximum - minimum}");


