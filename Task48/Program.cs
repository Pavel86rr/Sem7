//Задача 48. Задайте двухмерный массив  размером m и n 
//каждый элемент в массиве находится по формуле: Amn = m +n
//Выведите полученный массив на экран
// rows - 3; cols = 4.
// 0 1 2 3
// 1 2 2 4
// 2 3 4 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,]FillMatrix(int m, int n)
{
    int[,] Massiv = new int[m, n];

    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            Massiv[i, j] = i + j;
        }
    }
    return Massiv;
}



void PrintMatrix(int[,] Massiv)
{
    for (int i = 0; i < Massiv.GetLength(0); i++)
    {
        for (int j = 0; j < Massiv.GetLength(1); j++)
        {
            System.Console.Write(Massiv[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int[,] Matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "));

PrintMatrix(Matrix);

