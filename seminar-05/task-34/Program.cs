// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Программа создает массив заполненный случайными положительными трёхзначными числами, затем показывает количество чётных чисел в массиве.");

int evenNumbersCount = 0;
int arrayNumbersSize = new Random().Next(1, 10);
int[] arrayNumbers = new int[arrayNumbersSize];

for (int i = 0; i < arrayNumbers.Length; i++) {
    arrayNumbers[i] = new Random().Next(100, 999);    
    if (arrayNumbers[i] % 2 == 0) 
        evenNumbersCount++;
}

Console.Write("Случайно созданный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayNumbers)}]");

Console.WriteLine($"Количество четных чисел: {evenNumbersCount}");

