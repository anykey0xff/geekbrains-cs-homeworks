// Задача 29: Напишите программу, которая спрашивает у пользователя кол-во элементов массива, затем сами элементы. Программ должна вывести массив на экран.
// 8
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.WriteLine("Программа спрашивает у пользователя кол-во элементов массива, затем сами элементы. Программ должна вывести массив на экран.");

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите элементы массива через пробел: ");
// string[] arrayString = Console.ReadLine().Split(" ");
// int[] arrayInt = new int[N];
// for (int i = 0; i < arrayInt.Length; i++) {
//     arrayInt[i] = int.Parse(arrayString[i]);           
// }

int[] arrayInt = new int[N];
for (int i = 0; i < arrayInt.Length; i++) {
    Console.Write($"Введите {i+1} элемент массива: ");
    arrayInt[i] = Convert.ToInt32(Console.ReadLine());          
}

Console.WriteLine($"[{string.Join(", ", arrayInt)}]");