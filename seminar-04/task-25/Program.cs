// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow = 1;
for (int i = 0; i < B; i++) {
    Pow = Pow * A;    
}

Console.WriteLine(Pow);