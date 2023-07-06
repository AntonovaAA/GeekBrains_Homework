// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Наибольшее число = {a}");
    Console.WriteLine($"Наименьшее число = {b}");
}
else
{
    Console.WriteLine($"Наибольшее число = {b}");
    Console.WriteLine($"Наименьшее число = {a}");
}

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine($"Наибольшее число = {a}");
    }
    else 
    {
        if (b>c)
        {
            Console.WriteLine($"Наибольшее число = {b}");
        }
        else
        {
            Console.WriteLine($"Наибольшее число = {c}");
        }
    }
}
else 
{
    if (b>c)
    {
        Console.WriteLine($"Наибольшее число = {b}");
    }
    else 
    {
        Console.WriteLine($"Наибольшее число = {c}");
    }
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int a;
a = int.Parse(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
N = int.Parse(Console.ReadLine());
Console.Write($"Четные числа от 1 до {N}:");
for (int i = 2; i <= N; i += 2)
{
    Console.Write(i + " ");
}

