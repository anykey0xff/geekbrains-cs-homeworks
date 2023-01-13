// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

// Создаем случайный размер матриц
int M = new Random().Next(1,5);
int N = new Random().Next(1,5);
int P = new Random().Next(1,5);

// Создаем случайную матрицу M x N
Console.WriteLine();
Console.WriteLine($"Сгенерирована случайная матрица {M} x {N}: ");
int[,] matrixA = new int[M,N];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        matrixA[i,j] = new Random().Next(0, 10);
        Console.Write($"{matrixA[i,j]}\t");
    }  
    Console.WriteLine();  
}

// Создаем случайную матрицу N x P
Console.WriteLine();
Console.WriteLine($"Сгенерирована случайная матрица {N} x {P}: ");
int[,] matrixB = new int[N,P];
for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        matrixB[i,j] = new Random().Next(0, 10);
        Console.Write($"{matrixB[i,j]}\t");
    }  
    Console.WriteLine();  
}

// Ищем и выводим произведение матриц
Console.WriteLine();
Console.WriteLine($"Получено произведение матриц: ");
int[,] matrixC = new int[M,P];
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        matrixC[i,j] = 0;
        for (int k = 0; k < N; k++)
        {
            matrixC[i,j] = matrixC[i,j] + matrixA[i,k] * matrixB[k,j];
        }
        Console.Write($"{matrixC[i,j]}\t");
    }  
    Console.WriteLine();  
}

Console.WriteLine();
Console.ReadKey(); 
