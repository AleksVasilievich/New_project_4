﻿// Задача 29: Напишите программу, которая задаёт массив целых чисел
// и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write(" Введите размер массива N ->  ");

int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
}

