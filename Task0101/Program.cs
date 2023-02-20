// Габиль Асланов: Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");

var matrix = GetMatrix(numRows, numColumns);
Print(matrix);

int SetNumber(string numberName)
{
Console.Write($"Enter number {numberName}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int [,] GetMatrix (int rows, int columns)
{
int [,] matrix = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
for (int l = 0; l < columns; l++)
{
matrix [i, l] = i + l;
}
}
return matrix;
}

void Print(int [ , ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int l = 0; l < matrix.GetLength(1); l++)
{
System.Console.Write(matrix[i, l] + " ");

}
System.Console.WriteLine();
}
}

