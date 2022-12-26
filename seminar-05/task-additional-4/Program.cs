// Статистика
//
// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться ударником.
// В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а по четным – четверки.
// Так же он помнит, в какие дни он получал эти оценки.
// Поэтому он выписал на бумажке все эти дни для того, чтобы оценить, сколько у него троек и сколько четверок.
// Помогите Васе это сделать, расположив четные и нечетные числа в разных строчках.
// Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек. 

Console.Clear();
Console.WriteLine("Программа \"Статистика\"");

int arrayNumbersSize = new Random().Next(1, 10);
int[] arrayNumbers = new int[arrayNumbersSize];
string[] arrayEven = new string[arrayNumbersSize];
string[] arrayOdd = new string[arrayNumbersSize];

int arrayEvenCount = 0;
int arrayOddCount = 0;

for (int i = 0; i < arrayNumbers.Length; i++) {
    arrayNumbers[i] = new Random().Next(1, 31);
    if (arrayNumbers[i] % 2 == 0) {
        arrayEven[arrayEvenCount] = $"{arrayNumbers[i]}";
        arrayEvenCount++; 
    } 
    if (arrayNumbers[i] % 2 == 1) {
        arrayOdd[arrayOddCount] = $"{arrayNumbers[i]}";
        arrayOddCount++; 
    }    
}

Console.WriteLine();
Console.WriteLine($"Случайно созданный массив: [{string.Join(", ", arrayNumbers)}]");

Console.WriteLine();
Console.WriteLine($"Дни с тройками: {string.Join(", ", arrayOdd, 0, arrayOddCount)}");
Console.WriteLine($"Дни с четверками: {string.Join(", ", arrayEven, 0, arrayEvenCount)}");
Console.WriteLine($"Вася может расчитывать на четверку: {arrayEvenCount > arrayOddCount}");

Console.WriteLine();