﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100.
//  Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,90].

using System;

class Program
{
    static void Main()
    {
        // Создание массива
        int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
        
        // Инициализация счетчика
        int count = 0;
        
        // Проход по элементам массива
        foreach (int number in array)
        {
            // Проверка условия принадлежности отрезку [10, 90]
            if (number >= 10 && number <= 90)
            {
                count++;
            }
        }
        
        // Вывод результата
        Console.WriteLine(count); // Ожидаемый вывод: 5
    }
}
