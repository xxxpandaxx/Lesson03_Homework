//По двум заданным числам проверять является ли одно квадратом другого
int a,b;

Console.Write("number a : ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("number b : ");
b = Convert.ToInt32(Console.ReadLine());



if (a*a == b * b)
{
    Console.Write($"Число {a} является квадратом друг друга {b}");
}
else
{
    Console.Write($"Число {a} не является квадратом друг друга {b}");
}


