/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] GenerateArray(int height, int weight, int startPoint, int endPoint)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(1, 5);
        }
    }
    return generatedArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[] SumRowsArray(int[,] array)
{
    int[] sumRow = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            sum += array[i, j];

        }
        sumRow[i] = sum;
    }
    return sumRow;
}
void PrintSumRow(int[] array)
{
    int minSumElemets = array[0];
    int row = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSumElemets)
        {
            minSumElemets = array[i];
            row = i + 1;
        }

    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов:{row}");
}

int[,] generatedArray = GenerateArray(5, 6, 1, 5);
showArray(generatedArray);
Console.WriteLine();
int[] sumOfRows = SumRowsArray(generatedArray);
PrintSumRow(SumRowsArray(generatedArray));