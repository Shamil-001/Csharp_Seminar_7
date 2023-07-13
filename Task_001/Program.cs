// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matrixForPrint)
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

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
double[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);