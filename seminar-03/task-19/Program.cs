// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите пятизначное число: ");
string? s = Console.ReadLine();

if (s != null && s != "") {

    int[] numbers = new int[5];
    for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = Convert.ToInt32(Convert.ToString(s[i]));    
    }

    if (numbers[0] == numbers[4] && numbers[1] == numbers[3]) 
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");

}