// 16. Дано число. Проверить кратно ли оно 7 и 23

int number;

Console.Write("Введите число : ");
number=Convert.ToInt32(Console.ReadLine());



if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} не кратно 7 и 23");
}









