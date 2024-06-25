// Задайте массив на 10 целых чисел. Напишите программу, 
// которая определяет количество чётных чисел в массиве.

// Начальные условия:

// int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
// Выводится: 6

using System;

class ArrayProcessor
{
    private int[] array;

    public ArrayProcessor(int[] array)
    {
        this.array = array;
    }

    public int CountEvenNumbers()
    {
        int evenCount = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}

// Создание массива и выполнение программы
public class ProgramRunner
{
    public int Run()
    {
        // Создание массива
        int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };

        // Создание экземпляра ArrayProcessor
        ArrayProcessor processor = new ArrayProcessor(array);

        // Определение и вывод количества чётных чисел
        int evenCount = processor.CountEvenNumbers();
        Console.WriteLine(evenCount); // Ожидаемый вывод: 6

        return evenCount;
    }
}

// Запуск программы
class Program
{
    static void Main()
    {
        ProgramRunner runner = new ProgramRunner();
        runner.Run();
    }
}
