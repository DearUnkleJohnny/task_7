//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9




double[,] CreateRandom2DArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double x = new Random().NextDouble();
            newArray[i, j] = new Random().Next(-9, 9) + x;

        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + " | ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray);

Console.Write("Введите количество строк: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int x = Convert.ToInt32(Console.ReadLine());

Show2DArrayEllements(myArray[c, x]);


//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


double[,] CreateRandom2DArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double x = new Random().NextDouble();
            newArray[i, j] = new Random().Next(-9, 9) + x;

        }
    }
    return newArray;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 1) + " | ");
        }
        Console.WriteLine();
    }
}

void Show2DArrayEllements(int c, int x)
{
    int b1 = m - 1;
    int b2 = n - 1;
    if (c <= b1 && x <= b2)
    {
        double ellements = myArray[c, x];
        Console.WriteLine(Math.Round(myArray[c, x], 1));
    }
    else Console.WriteLine($"{c}, {x} -> такого эллемента в массиве нет.");
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2DArray(m, n);
Show2DArray(myArray);

Console.Write("Введите строку массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец массива: ");
int x = Convert.ToInt32(Console.ReadLine());

Show2DArrayEllements(c, x);




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




int[,] array = new int[,] { { 32, 27, 11 }, { 15, 34, 21 }, { 31, 14, 53 } };

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)
{

    for (int x = 0; x < array.GetLength(1); x++)
    {
        int result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, x] / 3;
        }
        Console.Write(result + " | ");

    }
}

Show2DArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
ArithmeticMean(array);