//04 Найти максимальное из трех чисел
int a,b,c;

Console.Write("Введите число a : ");
a = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите число b : ");
b = Convert.ToInt32 (Console.ReadLine());

Console.Write("Введите число c : ");
c = Convert.ToInt32 (Console.ReadLine());


if(a > b && a > c)
{
    Console.Write($"Чисто {a} больше остальных");
}
else if (b > a && b > c)
{
    Console.Write($"Чисто {b} больше остальных");
}
else if (c > a && c > b)
{
    Console.Write($"Чисто {c} больше остальных");
}
else
{
    Console.Write("error");
}