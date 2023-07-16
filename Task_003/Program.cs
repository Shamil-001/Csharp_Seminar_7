// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] tempMatrix = new double[row, col];
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

double[] ArithmeticMean(double[,] tempMatrix)
{
    double[] averages = new double[tempMatrix.GetLength(1)];
    for (int j = 0; j < tempMatrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < tempMatrix.GetLength(0); i++)
        {
            sum += tempMatrix[i, j];
        }
        averages[j] = sum / tempMatrix.GetLength(0);
    }
    return averages;
}

void PrintArithmeticMean(double[] arithmeticMeanForPrint)
{
    for (int i = 0; i < arithmeticMeanForPrint.Length; i++)
    {
        System.Console.Write(Math.Round(arithmeticMeanForPrint[i], 1) + "; ");
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int leftRange = ReadInt("Введите минимальное значение в массиве: ");
int rightRange = ReadInt("Введите максимальное значение в массиве: ");
double[,] matrixArray = FillMatrix(rows, cols, leftRange, rightRange);
System.Console.WriteLine();
PrintMatrix(matrixArray);
System.Console.WriteLine();
double[] arithmeticMeanarray = ArithmeticMean(matrixArray);
System.Console.Write("Количество строк в каждого столбца: ");
PrintArithmeticMean(arithmeticMeanarray);
