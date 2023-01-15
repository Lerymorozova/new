
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
Random rand = new Random();
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(234, 897);
    Console.Write($"{array[i]} ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine($"{result} ");

// Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
Random rand = new Random();
int summa = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-4, 89);
    Console.Write($"{array[i]} ");
}
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summa += array[i];
        }
    }
        Console.WriteLine($"{summa} ");