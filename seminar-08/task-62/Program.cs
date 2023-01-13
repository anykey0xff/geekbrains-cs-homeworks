// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Программа генерирует и заполняет спирально массив 4 на 4.");

// Создаем матрицу 4 x 4, заполняем спирально.
int[,] matrix = new int[4,4];
matrix[0,0] = 1;
int currentNumber = 2, i = 0, j = -1;
int maxi = matrix.GetLength(0)-1;
int maxj = matrix.GetLength(1)-1;
while (currentNumber < matrix.GetLength(0)*matrix.GetLength(1))
{ 
    // Движемся вправо
    i++;
    j++;
    while (i <= maxi) {
        matrix[j,i] = currentNumber;
        currentNumber++;
        i++;    
    }

    // Движемся вниз
    i--;
    j++;
    while (j <= maxj) {
        matrix[j,i] = currentNumber;
        currentNumber++;
        j++;
    } 

    // Движемся влево
    i--;
    j--;
    while (i >= matrix.GetLength(0) - maxi - 1) {
        matrix[j,i] = currentNumber;
        currentNumber++;
        i--;
    } 

    // Движемся вверх
    i++;
    j--;
    while (j >= matrix.GetLength(1) - maxj) {
        matrix[j,i] = currentNumber;
        currentNumber++;
        j--;
    }

    maxi--;
    maxj--;  
    
}

// Выводим результат
Console.WriteLine();
Console.WriteLine($"Сгенерирована матрица {matrix.GetLength(0)} x {matrix.GetLength(1)} заполненная спирально: ");
for (i = 0; i < matrix.GetLength(0); i++)
{
    for (j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i,j]}\t"); 
    Console.WriteLine();  
}

Console.WriteLine();
Console.ReadKey(); 
