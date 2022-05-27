/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2                -1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Задача 41. Определение количества чисел больше 0, введённых пользователем ");

Console.Write("Введите числа через пробел: ");

int[] M = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum=0;

for (int i = 0; i < M.Length; i++)
   {
    if (M[i]>0)
    {
        sum = sum +1;
        Console.Write(M[i] + " ");
    }
   } 
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 равно: {sum}");
Console.WriteLine();

/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Задача 43. Программа, нахождения точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

double y = 0;
double x = 0;

if (k1==k2)
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        x = (b1-b2) / (k2 - k1);
        
        y = k2 * x + b2;

        Console.WriteLine($"Точка пересечения прямых x={Math.Round(x, 2)} y={Math.Round(y, 2)}");
        
    }

