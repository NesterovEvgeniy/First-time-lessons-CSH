                                                 // ПРОГРАММЫ РАБОТАЮТ (НЕОБХОДИМО ПРОВЕРЯТЬ ПО ОТДЕЛЬНОСТИ)


/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine();

Console.WriteLine("Задача 47. Заполнение массива n x m случайными вещественными числами");

Console.Write("Введите количество строк в массиве n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве m: ");
int m = int.Parse(Console.ReadLine());

double [,] mass = new double [n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(-10, 10) + new Random().NextDouble();
    }
    }
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write($"{Math.Round(mass[i,j],2) + "   "}");
    }
    Console.WriteLine();
}

Console.WriteLine();


/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/* Console.WriteLine();

Console.WriteLine("Задача 52. Программа нахождения ЧИСЛА в массиве n x m");

Console.Write("Введите количество строк в массиве n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число для поиска его в массиве m х n: ");
int num = int.Parse(Console.ReadLine());

int [,] mass = new int [n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1, 10);
    }
    }
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(); 

int Count = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (num==mass[i,j])
        {
            Count = Count + 1;
        }
    }
}

if (Count > 0)
        {
            Console.Write($"Число {num} присутствует в массиве m x n");
        }
        else
        {
            Console.Write($"Число {num} отсутствует в массиве m x n");
        }
Console.WriteLine(); */


/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* Console.WriteLine();

Console.WriteLine("Задача 52. Нахождение среднеарифметического элементов в каждом столбце массива n x m");

Console.Write("Введите количество строк в массиве n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве m: ");
int m = int.Parse(Console.ReadLine());

int [,] mass = new int [n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(-10, 10);
    }
    }
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(); 

int sum = 0;

for (int j = 0; j < mass.GetLength(0); j++)

{
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        sum = sum + mass[i,j];
    }
    Console.Write(sum + " ");
    
    sum = 0;
}
Console.WriteLine(); */
