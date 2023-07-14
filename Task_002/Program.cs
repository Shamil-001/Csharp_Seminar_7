// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// int FindElement(int[,] tempMatrix, int positionLine, int positionColumn)
// {
//     for (int i = 0; i < tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < tempMatrix.GetLength(1); j++)
//         {
//             if (tempMatrix[i, j] == tempMatrix[positionLine, positionColumn])
//             {
//                 tempMatrix[i, j] = tempMatrix[positionLine, positionColumn];
//             }
//         }
//     }
//     System.Console.WriteLine("Такой позиции не существует");
//     return tempMatrix[positionLine, positionColumn];
// }
void FindElement(int[,] tempMatrix, int row, int col, int positionLine, int positionColumn)
{

    if (row >= positionLine && col >= positionColumn)
    {
        System.Console.WriteLine(tempMatrix[positionLine, positionColumn]);
    }
    else
    {
        System.Console.WriteLine("Такой позиции не существует");
    }
}





int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int leftRange = ReadInt("Введите минимальное значение в массиве: ");
int rightRange = ReadInt("Введите максимальное значение в массиве: ");
int positionLine = ReadInt("Введите номер строки массива: ");
int positionColumn = ReadInt("Введите номер столбца массива");
int[,] matrixArray = FillMatrix(rows, cols, leftRange, rightRange);
System.Console.WriteLine();
PrintMatrix(matrixArray);
System.Console.WriteLine();
FindElement(matrixArray, rows, cols, positionLine, positionColumn);


