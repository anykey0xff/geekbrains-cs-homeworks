// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Программа генерирует и построчно выводить массив трёхмерный массив из неповторяющихся двузначных чисел, добавляя индексы каждого элемента.");

// Создаем случайный размер матриц
int M = new Random().Next(1,5);
int N = new Random().Next(1,5);
int P = new Random().Next(1,5);

// Создаем случайную матрицу M x N x P
Console.WriteLine();
Console.WriteLine($"Сгенерирована случайная матрица {M} x {N} x {P}: ");
int[,,] matrix = new int[M,N,P];
int[] numbers = new int[M*N*P+1];
int x = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            int newNumber = 0;
            bool isRecurring = true;
            while(isRecurring)
            {
                isRecurring = false;
                newNumber = new Random().Next(10, 100);
                for (int l = 0; l < numbers.Length; l++)
                    if (newNumber == numbers[l]) isRecurring = true;
            }
            numbers[x] = newNumber;
            x++;
            matrix[i,j,k] = newNumber;
            Console.Write($"{matrix[i,j,k]}({i},{j},{k})\t");
        }
        Console.WriteLine(); 
    }  
    Console.WriteLine();  
}

Console.WriteLine();
Console.ReadKey(); 
