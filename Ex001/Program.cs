// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2. Нахождение большего числа.");

Console.Write("Введите первое число: ");

int num_a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num_b = int.Parse(Console.ReadLine());

if (num_a > num_b) 
{
    int max = num_a;
    Console.Write("Максимальное число: ");
    Console.Write(max);
}
else
{
    int max = num_b;
    Console.Write("Максимальное число: ");
    Console.WriteLine(max);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4. Нахождение максимального из трёх чисел.");

Console.Write("Введите первое число: ");

int num_aa = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");

int num_bb = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");

int num_сc = int.Parse(Console.ReadLine());

int maxx=0;

if (num_aa > num_bb) 
{
    maxx = num_aa;
}
else
{
    maxx = num_bb;
}

if (maxx > num_сc) 
{
    Console.Write("Максимальное число: ");
    Console.Write(maxx);
}
else
{
    maxx = num_сc;
    Console.Write("Максимальное число: ");
    Console.WriteLine(maxx);
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6. Определение чётности числа.");

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());

int a = num % 2;

if (a == 0)

{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8. Определение всех чётных чисел от 1 до N.");

Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine());

int b = 1;

 Console.WriteLine("Чётные числа от 1 до N: ");

while (b <= N)
{
    int z = b % 2;
    
    if (z == 0)
    Console.WriteLine(b);
    b=b+1;
}
