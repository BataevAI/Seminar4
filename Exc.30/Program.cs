﻿// Задача 30: Напишите программу, 
// которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// создаем метода заполнения массива размера size - нулем или единицой

int[] FillRandomArray(int size)

{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

// void PrintArray(int[] arr)
// {
//     foreach (var el in arr)
//     {
//         Console.Write(el + " ");
//     }
// }

int[] array = FillRandomArray(8);
Console.WriteLine(string.Join(" ; ", array));