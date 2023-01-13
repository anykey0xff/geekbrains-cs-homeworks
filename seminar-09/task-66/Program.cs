// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Программа находит сумму натуральных элементов в промежутке от M до N. Выполняется с помощью рекурсии.");

// Рекурсивный метод выводящий следующее натуральное число
int RecursiveSum(int N, int M)
{
    int sum = 0;
    if (M > N)
        sum = RecursiveSum(N+1,M);     
    if (M < N)
        sum = RecursiveSum(N-1,M);
    return N + sum;
}

// Вводим значения M и N
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// Рекурсивный метод выполняющий задачу
int sum = RecursiveSum(N, M);

// Выводим результат
Console.WriteLine($"Сумма числе от M до N: {sum}");

Console.WriteLine("\n");
Console.ReadKey(); 
