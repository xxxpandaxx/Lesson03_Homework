//02 Даны два числа. Показать большее и меньшее число

int a, b;

Console.Write("Number one : ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Number two : ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("a > than b");
}
else if (a < b)
{
    Console.WriteLine("a < than b");
}
else
{
    Console.WriteLine("a = b");
}

