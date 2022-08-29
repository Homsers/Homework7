Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n, int minValue, int maxValue)

{
{
    double[,] arrays = new double [m, n];
    
    for (int i = 0; i<m; i++)
        for(int j=0; j<n; j++)
           arrays[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue));

    return arrays;
    
}
}
void PrintArray(double[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) {
        for(int j = 0; j<array.GetLength(1); j++)
           Console.Write($"[{array[i, j]}]");
        Console.WriteLine();
        Console.WriteLine();
    }
}


double[,] myArray = GetArray(m, n, -10, 10);
PrintArray(myArray);