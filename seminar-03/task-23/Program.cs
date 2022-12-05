// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];
for (int i = 0; i < numbers.Length; i++) 
    numbers[i] = Convert.ToInt32(Math.Pow(i + 1, 3));

Console.WriteLine($"{string.Join(", ", numbers)}");