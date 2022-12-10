// Задача 36: Задайте одномерный массив, заполненный случайными
//  числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
var rnd = new Random();
var arr = new int[10];
for (int i = 0; i < arr.Length; i++)
    Console.Write("{0}\t", arr[i] = rnd.Next(1, 100));
Console.WriteLine();
var odd = arr.Where((element, index) => index % 2 == 0);
Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());

