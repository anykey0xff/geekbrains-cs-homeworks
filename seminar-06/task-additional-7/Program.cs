// Площадь треугольника
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь. 

Console.Clear();
Console.WriteLine("Программа \"Площадь треугольника\"\n");

double[,] coordinates = new double[3,2];

for (int i = 0; i < coordinates.GetLength(0); i++)
{
    for (int j = 0; j < coordinates.GetLength(1); j++)
    {
        string axisName;
        if (j == 0) axisName = "X";
        else axisName = "Y";
        Console.Write($"Вершина {i+1} координата {axisName}: ");
        coordinates[i,j] = Convert.ToInt32(Console.ReadLine());    
    }     
}

double l12 = Math.Sqrt(Math.Pow(coordinates[0,0] - coordinates[1,0], 2) + Math.Pow(coordinates[0,1] - coordinates[1,1], 2));
double l13 = Math.Sqrt(Math.Pow(coordinates[0,0] - coordinates[2,0], 2) + Math.Pow(coordinates[0,1] - coordinates[2,1], 2));
double l23 = Math.Sqrt(Math.Pow(coordinates[2,0] - coordinates[1,0], 2) + Math.Pow(coordinates[2,1] - coordinates[1,1], 2));
double p = (l12 + l13 + l23) / 2;

double square = Math.Sqrt(p * (p-l12) * (p-l13) * (p-l23));

Console.WriteLine($"Площадь треугольника: {square}");
