// Транспонирование - 4
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.
// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали. 

Console.Clear();
Console.WriteLine("Программа \"Транспонирование\"");

int M = new Random().Next(1,5);
int N = new Random().Next(3,6);

Console.WriteLine();
Console.WriteLine($"Сгенерирована матрица {M} x {N}: ");

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

// Транспонируем
for (int i = 0; i < intArray.GetLength(0) / 2; i++)
{
    for (int j = 0; j < intArray.GetLength(1); j++)
    {
        int temp = intArray[i,j];
        intArray[i,j] = intArray[M-i-1,j];
        intArray[M-i-1,j] = temp;
    }   
}

// Выводим в консоль
Console.WriteLine();
Console.WriteLine($"Транспонированная по горизонтали матрица: "); 
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
