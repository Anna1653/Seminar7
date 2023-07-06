/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

System.Console.Write("Enter num rows :");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num colmns :");
int colmns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows,colmns);

Print(matrix);

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double colmn = 0;
    for (int l = 0; l < matrix.GetLength(0); l++)
    {
        colmn = colmn + matrix[l, i];
    }
    Console.WriteLine($"Среднее арифметическое элементов в столбце {i + 1}: {colmn/matrix.GetLength(0)}");
}

int[,] InitMatrix(int rows, int colmns)
{
    int[,] tmp = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < colmns; l++)
        {
            tmp[i, l] = random.Next(10, 101);
        }

    }
    return  tmp;
}

void Print(int[,] arr){
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
          System.Console.Write($"{ arr[i, l] }  " );
        }
        System.Console.WriteLine();
    } 
}
