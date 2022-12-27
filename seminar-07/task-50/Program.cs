// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет

Console.Clear();
Console.WriteLine("Программа принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

int M = new Random().Next(1,10);
int N = new Random().Next(1,10);

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
Console.Write($"Введите 1 индекс позиции элемента (от 0 до {M-1}): ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите 2 индекс позиции элемента (от 0 до {N-1}): ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X >= M || Y >= N)
    Console.WriteLine($"Позиции {X} x {Y} в массиве нет.");
else
    Console.WriteLine($"Yf позиции {X} x {Y} в массиве стоит число {intArray[X,Y]}.");

Console.WriteLine();
