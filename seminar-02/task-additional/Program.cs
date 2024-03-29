﻿// Задана последовательность натуральных чисел, завершающаяся числом 0.
// Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента,
// который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();
Console.WriteLine("Программа определяет значение второго по величине элемента в последовательности натуральных чисел, завершающаяся числом 0.");

int a;
int max1 = 0;
int max2 = 0;

Console.WriteLine("Введите последовательность чисел, каждое число с новой строки. Последнее число последовательности должно быть 0.");
while (true) {
    a = Convert.ToInt32(Console.ReadLine()); 
    if (a == 0) break;
    if (a > max1) {
        max2 = max1;
        max1 = a;
    }   
}

Console.WriteLine($"Второй максимум: {max2}");