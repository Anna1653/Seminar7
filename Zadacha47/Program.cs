/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

System.Console.Write("Enter num rows :");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num colmns :");
int colmns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows,colmns];

GetMatrix(matrix);
Print(matrix);

void GetMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Random random = new Random();
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            arr[i, l] = Convert.ToDouble(random.Next(-10, 10)) / 10;
        }
    }
}

void Print(double[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
          Console.Write($"{ arr[i, l] }  " );
        }
        Console.WriteLine();
    } 
}