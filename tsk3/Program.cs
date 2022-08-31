Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    
    for (int i = 0; i<m; i++)
        for(int j=0; j<n; j++)
           result[i, j] = new Random().Next(minValue, maxValue+1);

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) {
        for(int j = 0; j<array.GetLength(1); j++)
           Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
void PrintArray2(int[,] array2)
{
for (int j = 0; j < array2.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        sum += array2[i, j];
    }
    Console.Write($"[{Math.Round(( sum / array2.GetLength(0)))}] ");


}
Console.ReadLine();

}
int[,] myArray = GetArray(m, n, 0, 9);

PrintArray(myArray);
PrintArray2(myArray);


