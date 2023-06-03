// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void PrintSearch(int[,] matrix)
{
    int a = ReadInt("Введите координату а: ");
    int b = ReadInt("Введите координату b: ");
    int [,] c = new int[a,b];
    if (a-1 < matrix.GetLength(0) && b-1 < matrix.GetLength(1))
    {
        Console.WriteLine(matrix[a-1,b-1]);
    }
    else
    {
        Console.WriteLine($"{a},{b} -> с такими координатами числа в массиве нет");
    }

}



int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 9, 100);
PrintMatrix(matrix);
PrintSearch(matrix);

//Сознательно перевел коордитаты в индекс (так обыаателю более понятно). 

