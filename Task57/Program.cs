int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FreqAnalysis(int[,] inArray, int minValue, int maxValue)
{
    int[] tempArray = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            tempArray[i + j + (i * (inArray.GetLength(1)-1))] = inArray[i, j];
        }
    }
    for (int num = minValue; num < maxValue + 1; num++)
    {
        int freq = 0;
        for (int numarray = 0; numarray < tempArray.Length; numarray++)
        {
            if (tempArray[numarray] == num)
            {
                freq = freq + 1;
            }
        }
        if (freq > 0)
        {
            Console.WriteLine($"Число {num} встречается {freq} раз");
        }
    }
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите начальное значение диапазона чисел массива: ");
int MinValue = int.Parse(Console.ReadLine());
Console.Write("Введите конечное значение диапазона чисел массива: ");
int MaxValue = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, MinValue, MaxValue);
PrintArray(array);
Console.WriteLine();
FreqAnalysis(array, MinValue, MaxValue);