/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(-deviation, deviation + 1);
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
int[,] GetSortElementsFromMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
    }
    return array;
}  

// {
//     int[] coordinate = new int[2];
//     int maxPosition = inputMatrix[0,0];
//     for (int j = 0; j < inputMatrix.GetLength(1); j++)
//     {
//         for (int i = j+1; j < inputMatrix.GetLength(0); j++)
//         {
//             if(inputMatrix[i,j] > maxPosition)
//             maxPosition = inputMatrix[i,j];
//             int buffer = inputMatrix[i,j];
//             inputMatrix[i,j] = maxPosition;
//             maxPosition = buffer;
//         }  
//     }
//     return inputMatrix;
// }
int[,] generatedArray = GenerateArray(5, 5, 10);
showArray(generatedArray);
Console.WriteLine();
int[,] swoppedArray = GetSortElementsFromMaxToMin(generatedArray); // (generatedArray, 1, 2)-замена значений между 1 и 2 строкой
showArray(swoppedArray);