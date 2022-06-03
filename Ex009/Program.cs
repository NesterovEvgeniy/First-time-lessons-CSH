/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N при (M > N и M < N)
M = 1; N = 5 -> "1, 2, 3, 4, 5";     M = 4; N = 8 -> "4, 5, 6, 7, 8" */

/*Console.Write("Задача 64: программа представления всех натуральных чисел в промежутке от M до N при (M > N и M < N)");

void Rec(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M + " ");
    Rec(M + 1, N);
}

void RecInvers(int M, int N)
{
    if (M < N)
    {
        return;
    }
    Console.Write(M + " ");
    RecInvers(M - 1, N);
}

Console.Write("Введите целое число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine());

if (M < N) Rec(M, N);
else RecInvers(M, N); */


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120;      M = 4; N = 8 -> 30 */

/*Console.Write("Задача 66: сумму натуральных элементов в промежутке от M до N.");

 int sum = 0;

void RecSum(int M, int N)
{
    if (M > N)
    {
        return;
    }
    sum += M;
    RecSum(M + 1, N);
}

Console.Write("Введите натуральное целое число M: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное целое число N: ");
int N = int.Parse(Console.ReadLine());

RecSum(M, N);
Console.WriteLine(sum); */


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

/* Console.Write();

Console.Write("Задача 68: Вычисление функции Аккермана");

Console.Write("Введите целое число m: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите целое число n: ");
int N = int.Parse(Console.ReadLine());

int m = 2;
int n = 3;
int A = 0;

int RecFunction(int m, int n)

{
    if (m == 0)
    {
        return A = n + 1;
    }
    if (n == 0)
    {
        return A = RecFunction(m - 1, 1);
    }
    else
    {
        return A = RecFunction(m - 1, RecFunction(m, n - 1));
    }
}

if (m < 0 || n < 0)
{
    Console.WriteLine("Функция Аккермана определяется только для неотрицательных целых чисел");
}

else

{
    RecFunction(m, n);
    Console.WriteLine($"Функция Аккермана равна:{A}");
} */