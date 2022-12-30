// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

// Создаем случайный размер массива
int M = new Random().Next(1,5);
int N = new Random().Next(1,5);

// Создаем массив случайных чисел
Console.WriteLine();
Console.WriteLine($"Сгенерирован случайный массив {M} x {N}: ");
int[,] intArray = new int[M,N];
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        intArray[i,j] = new Random().Next(0, 100);
        Console.Write($"{intArray[i,j]}\t");
    }  
    Console.WriteLine();  
}

// Ищем минимальную строку
int minSum = 0;
int minSumIndex = 0;
for (int i = 0; i < intArray.GetLength(0); i++)
{
    int currentSum = 0;
    for (int j = 0; j < intArray.GetLength(1); j++)
        currentSum += intArray[i,j];
    if (i == 0)
        minSum = currentSum;
    else if (minSum > currentSum)
    {
        minSum = currentSum;
        minSumIndex = i;
    }       
}

// Выводим результат
Console.WriteLine(); 
Console.WriteLine($"Минимальная сумма в строке {minSumIndex+1}: {minSum}");

Console.WriteLine();
Console.ReadKey(); 
