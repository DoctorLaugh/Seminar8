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
int[,] NewArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            if (inArray[i, j] < inArray[i, j + 1])
            {
                int minnum = inArray[i, j];
                int rowmin = i;
                int colmin = j;
            }
        }   
    }
    int[,] newArray = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (i == rowmin)
            {
                continue;
            }
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j == colmin)
            {
                continue;
            }
            newArray[row, column] = inArray[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return newArray;
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 10, 99);
PrintArray(array);
Console.WriteLine();
int[,] ModArray = NewArray(array);
PrintArray(ModArray);