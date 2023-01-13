// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Очищаем вывод консоли и выводим заголовок
Console.Clear();
Console.WriteLine("Программа вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

// Рекурсивный метод выводящий следующее натуральное число
int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

// Вводим значения M и N
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Рекурсивный метод выполняющий задачу
int sum = AckermannFunction(m, n);

// Выводим результат
Console.WriteLine($"A({m}, {n}) = {sum}");

Console.WriteLine("\n");
Console.ReadKey(); 
