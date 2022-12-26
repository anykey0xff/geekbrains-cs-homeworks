// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();
Console.WriteLine("Программа создает массив вещественных чисел, затем показывает разницу между максимальным и минимальным элементов массива.");

int arrayNumbersSize = new Random().Next(1, 10);
double[] arrayNumbers = new double[arrayNumbersSize];

for (int i = 0; i < arrayNumbers.Length; i++) {
    arrayNumbers[i] = new Random().NextDouble();     
}

double min = arrayNumbers[0];
double max = arrayNumbers[0]; 

for (int i = 0; i < arrayNumbers.Length; i++) {
    if (min > arrayNumbers[i]) min = arrayNumbers[i];
    if (max < arrayNumbers[i]) max = arrayNumbers[i];   
}

Console.Write("Случайно созданный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayNumbers)}]");

Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");

