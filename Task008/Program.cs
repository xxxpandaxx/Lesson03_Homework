//08 Показать четные числа от 1 до N

Console.WriteLine("Введите число : ");
int a;
a = Convert.ToInt32(Console.ReadLine());

int i;
for (i = 0; i <= a; ++i)
{
    if (i % 2 == 0)
    {
    Console.Write(i + " ");
    }
    
}