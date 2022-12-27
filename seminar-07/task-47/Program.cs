// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером M x N, заполненный случайными вещественными числами.\n");

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Сгенерирован массив: ");

double[,] doubleArray = new double[M,N];
for (int i = 0; i < doubleArray.GetLength(0); i++)
{
    for (int j = 0; j < doubleArray.GetLength(1); j++)
    {
        doubleArray[i,j] = new Random().NextDouble();
        Console.Write($"{doubleArray[i,j],1:N2}\t");
    }  
    Console.WriteLine();  
}

Console.WriteLine();
