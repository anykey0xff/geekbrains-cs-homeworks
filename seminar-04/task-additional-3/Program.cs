// Суперсдвиг
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
// если K – положительное и влево, если отрицательное.

Console.Clear();
Console.WriteLine("Программа \"Суперсдвиг\"\n");

Console.Write("Введите количество элементов последовательности: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число для сдвига: ");
int K = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(1, 10);
}

Console.WriteLine();
Console.WriteLine("Исходная последовательность: ");
Console.WriteLine($"[{string.Join(", ", array)}]");

if (K > 0) {
    for (int j = 0; j < K; j++) {
        int temp = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--) {       
            array[i] = array[i-1];       
        }
        array[0] = temp;    
    }
}
else {
    for (int j = 0; j < -K; j++) {
        int temp = array[0];
        for (int i = 0; i < array.Length - 1; i++) {      
            array[i] = array[i+1];
        } 
        array[array.Length - 1] = temp;
    } 
}

Console.WriteLine();
Console.WriteLine("Последовательность со сдвигом: ");
Console.WriteLine($"[{string.Join(", ", array)}]");