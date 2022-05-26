
//                                                Программы все рабочие. Необходимо проверять по очереди. (иначе возникает ошибка задвоения переменных)


/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Задача 34. Определение количества чётных чисел в массиве");

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());

int [] mass = new int[N];
FillArray (mass, 100, 1000);
PrintArray (mass);

int Count = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 0)
    {
        Count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных элементов массива: {Count}");


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19                  [-4, -6, 89, 6] -> 0 */

/* Console.WriteLine("Задача 36. Сумма элементов массива, стоящих на нечётных позициях");

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());

int [] mass = new int[N];
FillArray (mass, 0, 100);
PrintArray (mass);

int sum = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + mass[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: {sum}");

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

/* Console.WriteLine("Задача 36. Определение разницы между максимальным и минимальным элементом массива");

void FillArray(double[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());

double [] mass = new double[N];
FillArray (mass, 0, 100);
PrintArray (mass);

Console.WriteLine();

double max = mass[0];
double min = mass[0];

for (int i = 0; i < mass.Length; i++)
{   
    if (max < mass[i])
    {
        max = mass[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент {max}");

for (int i = 0; i < mass.Length; i++)
{   
    if (min > mass[i])
    {
        min = mass[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальный элемент {min}");

double result = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}"); */