// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

double[] pointA = new double[3];
for (int i = 0; i < pointA.Length; i++) {
    Console.Write($"Введите {i+1} координату точки A: ");
    pointA[i] = Convert.ToDouble(Console.ReadLine());
}

double[] pointB = new double[3];
for (int i = 0; i < pointB.Length; i++) {
    Console.Write($"Введите {i+1} координату точки B: ");
    pointB[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine(Math.Round(Math.Sqrt(
    Math.Pow(pointA[0] - pointB[0], 2) + 
    Math.Pow(pointA[1] - pointB[1], 2) + 
    Math.Pow(pointA[2] - pointB[2], 2))
    , 2));