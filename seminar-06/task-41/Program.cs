// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n");

Console.WriteLine("Введите последовательность чисел через пробел: ");
string[] arrayString = Console.ReadLine().Split(" ");
int[] arrayInt = new int[arrayString.Length];
for (int i = 0; i < arrayInt.Length; i++) {
    arrayInt[i] = int.Parse(arrayString[i]);           
}

int countNatural = 0;
for (int i = 0; i < arrayInt.Length; i++) {
    if (arrayInt[i] > 0) countNatural++;    
}

Console.WriteLine($"Чисел больше 0: {countNatural}\n");