//01. По двум заданным числам проверять является ли первое квадратом второго


int a,b;

Console.Write("Введите число a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b: ");
b = Convert.ToInt32(Console.ReadLine());


if (Math.Pow(b,2)==a)
{
    Console.WriteLine($"Число {a} является квадратом числа {b}");
}
else 
{ Console.WriteLine($"Число {a} не является квадратом числа {b}");}

