Console.Write("m=");
int m = int.Parse(Console.ReadLine());
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter a first number of element=");
int s = int.Parse(Console.ReadLine())-1;
Console.Write("Enter a second number of element=");
int c = int.Parse(Console.ReadLine())-1;

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    
    for (int i = 0; i<m; i++)
        for(int j=0; j<n; j++)
           result[i, j] = new Random().Next(minValue, maxValue);
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++) {
        for(int j = 0; j<array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
        if (s == array.GetLength(0)-1 | c == array.GetLength(1))
        Console.WriteLine();
    }
}


int[,] myArray = GetArray(m, n, 0, 10);
PrintArray(myArray);
Console.WriteLine("Number of element is {0}", myArray[s,c]);





