// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

// Создаем случайный размер массива
int M = new Random().Next(1,5);
int N = new Random().Next(1,5);

// Создаем массив случайных чисел
Console.WriteLine();
Console.WriteLine($"Сгенерирован массив {M} x {N}: ");
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

// Упорядочиваем массив
for (int i = 0; i < intArray.GetLength(0); i++)
{
    int j = 0;
    while (j < intArray.GetLength(1)-1) 
        if (intArray[i,j] < intArray[i,j+1])
        {
            int temp = intArray[i,j];
            intArray[i,j] = intArray[i,j+1];
            intArray[i,j+1] = temp;
            j = 0;
        }
        else j++;     
}

// Выводим полученный упорядоченный массив
Console.WriteLine(); 
Console.WriteLine("Упорядоченный массив: ");
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
        Console.Write($"{intArray[i,j]}\t"); 
    Console.WriteLine();  
}

Console.WriteLine();
Console.ReadKey(); 
