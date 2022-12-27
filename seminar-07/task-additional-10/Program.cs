// Заполнение диагоналями
//
// Даны числа N и M. Создайте массив A[N][M] и заполните его как показано на примере.
//  0  1  3  6
//  2  4  7  9
//  5  8 10 11

Console.Clear();
Console.WriteLine("Программа \"Заполнение диагоналями\"");

int M = new Random().Next(1,10);
int N = new Random().Next(1,10);

int inc = 0;
int[,] intArray = new int[M,N];
for (int d = 0; d < M+N-1; d++)
{
    for (int i = 0; i < d+1; i++)
    {
        if ((i < M) && (d-i < N))
        {
            intArray[i,d-i] = inc;
            inc++; 
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Сгенерирована матрица {M} x {N}: ");
for (int i = 0; i < intArray.GetLength(0); i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        Console.Write($"{intArray[i,j]}\t");
    }  
    Console.WriteLine();  
}

Console.WriteLine(); 
Console.ReadKey(); 
