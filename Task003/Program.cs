﻿//03 По заданному номеру дня недели вывести его название

int a;

Console.Write ("Введите день недели от 1 до 7 : ");

a = Convert.ToInt32 (Console.ReadLine());


if (a == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник");
}
else if (a == 3)
{
    Console.WriteLine("Сегодня среда");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (a == 5)
{
    Console.WriteLine("Сегодня пятница");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня суббота");
}
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}