/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int m = 5;
int n = 5;

int[,] arr = new int[n, m];
Random random = new Random();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(0); l++)
        {
            arr[i, l] = random.Next(10, 100);
            
        }
    }
Print(arr);

System.Console.Write("Enter number of row :");
int row = Convert.ToInt32(Console.ReadLine()) - 1;

System.Console.Write("Enter number of colmn :");
int colmn = Convert.ToInt32(Console.ReadLine()) - 1;

if (row > arr.GetLength(0) || colmn > arr.GetLength(1) || row < 0 || colmn < 0)
{
    Console.WriteLine("Такой элемент не существует");
}
else
{
    Console.WriteLine($"Элемент равен: {arr[row, colmn]}");
}

void Print(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
          System.Console.Write($"{ arr[i, l] }  " );
        }
        System.Console.WriteLine();
    } 
}