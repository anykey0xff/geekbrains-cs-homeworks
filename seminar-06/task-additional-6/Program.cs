// Перестановки
//
// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки. 

bool IsInputCorrect(string? inputString)
{
    if (inputString == null || inputString == "")
        return false;
    
    for (int i = 0; i < inputString.Length-1; i++)
    {
        for (int j = i+1; j < inputString.Length; j++)
        {
            if (inputString[i] == inputString[j]) return false;
        }
    }
    return true;
}

void Permute(char[] charArray, int i, int n)
{
    if (i == n)
    {
        Console.Write("- ");
        for (int j = 0; j < charArray.Length; j++)
            Console.Write(charArray[j]);
        Console.WriteLine();
    }
    else
    {
        for (int j = i; j < n; j++)
        {
            Swap(charArray, i, j);
            Permute(charArray, i+1, n);
            Swap(charArray, i, j);
        }
    }
}

void Swap(char[] charArray, int i, int j)
{
	char temp = charArray[i];
	charArray[i] = charArray[j];
	charArray[j] = temp;
}

Console.Clear();
Console.WriteLine("Программа \"Перестановки\"\n");

Console.Write("Введите строку попарно различных символов: ");
string? inputString = Console.ReadLine();

while (!IsInputCorrect(inputString))
{
    Console.Write("Ошибка ввода. Введите строку попарно различных символов: ");
    inputString = Console.ReadLine();   
}

char[] charArray = new char[inputString.Length];
for (int i = 0; i < inputString.Length; i++)
{
    charArray[i] = inputString[i]; 
}

Console.WriteLine("Варианты перестановок: ");
Permute(charArray, 0, inputString.Length);
Console.WriteLine();
