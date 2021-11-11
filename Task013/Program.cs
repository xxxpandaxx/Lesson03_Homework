//Выяснить, кратно ли число заданному, если нет, вывести остаток.

int a, b;

Console.Write(" a =");
a = Convert.ToInt32(Console.ReadLine());

Console.Write(" b =");
b = Convert.ToInt32(Console.ReadLine());

int remains;
if (a % b == 0)
{
    Console.Write("Числа кратны");
}
else
{
    remains = a % b;
    Console.WriteLine($"остаток {remains}");
}




