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
int[,] ChangeRowsColumns(int[,] inArray)
{
    int[,] newArray = new int[inArray.GetLength(1), inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            newArray[j, i] = inArray[i, j];
        }
    }
    return newArray;
}
bool TestPos(int[,] inArray)
{
    if (inArray.GetLength(0) != inArray.GetLength(1))
    {
        Console.WriteLine("Выполнение симметричной замены строк на столбцы невозможно!");
        return false;
    }
    else
    {
        return true;
    }
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("");
TestPos(array);
Console.WriteLine("");
int[,] newArray = ChangeRowsColumns(array);
PrintArray(newArray);