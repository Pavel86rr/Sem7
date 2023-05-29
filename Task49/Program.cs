// Задача 49. Задайте двухмерный массив.
// Найдите элементы, у которых оба элемента
//нечетные, и заменить эти элементы на их
//квадраты
//1 4 7 2       1 4  7 2 
//5 9 2 3       5 81 2 9
//8 4 2 4       8 4  2 4
void Task49()
{
    int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "),ReadInt("Введите количество столбцов: "), 9, 20);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    Transform(matrix);

    PrintMatrix(matrix);
}

void Transform(int [,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i+=2)
    {
        for (int j = 1; j < matr.GetLength(1); j+=2)
        {
            matr[i, j] = (int)Math.Pow(matr[i, j],2);
        }
    }
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Task49();