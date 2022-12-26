// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Программа создает одномерный массив, заполненный случайными числами, затем показывает сумму элементов стоящих на нечётных позициях.");

int sum = 0;
int arrayNumbersSize = new Random().Next(1, 10);
int[] arrayNumbers = new int[arrayNumbersSize];

for (int i = 0; i < arrayNumbers.Length; i++) {
    arrayNumbers[i] = new Random().Next(-100, 100);    
    if ((i+1) % 2 == 1) 
        sum += arrayNumbers[i];
}

Console.Write("Случайно созданный массив: ");
Console.WriteLine($"[{string.Join(", ", arrayNumbers)}]");

Console.WriteLine($"Сумма элементов стоящих на нечётных позициях: {sum}");

