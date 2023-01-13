// Задача 64: Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.
// M = 1; N = 5. -> "5,4,3,2,1"
// M = 4; N = 8. -> "8, 7, 6, 5, 4"

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Программа выводит все натуральные числа в промежутке от N до M. Выполняется с помощью рекурсии.");

// Рекурсивный метод выводящий следующее натуральное число
void RecursivePrint(int N, int M)
{
    Console.Write($"{N} ");
    if (M > N) 
        RecursivePrint(N+1,M);
    if (M < N)
        RecursivePrint(N-1,M);
}

// Вводим значения M и N
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// Рекурсивный метод выполняющий задачу
RecursivePrint(N, M);

Console.WriteLine("\n");
Console.ReadKey(); 
