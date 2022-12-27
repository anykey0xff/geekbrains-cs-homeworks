// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

int M = new Random().Next(1,5);
int N = new Random().Next(1,5);

Console.WriteLine();
Console.WriteLine($"Сгенерирован массив {M} x {N}: ");

int[,] intArray = new int[M,N];
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        intArray[i,j] = new Random().Next(1, 100);
        Console.Write($"{intArray[i,j]}\t");
    }  
    Console.WriteLine();  
}

Console.WriteLine(); 
for (int i = 0; i < intArray.GetLength(1); i++)
{
    double average = 0;
    for (int j = 0; j < intArray.GetLength(0); j++)
    {
        average += intArray[j,i];     
    }
    average = average / M;
    Console.WriteLine($"Среднее арифметическое чисел {i+1} столбца: {average:N1}");
}

Console.WriteLine(); 
