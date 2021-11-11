//Дано число обозначающее день недели. Выяснить является номер недели выходным днём


int a;

Console.Write ("Введите день недели от 1 до 7 : ");

a = Convert.ToInt32 (Console.ReadLine());


if (a == 1)
{
    Console.WriteLine("Сегодня понедельник.Неделя только начинается");
}
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник.Еще четыре дня до выходного");
}
else if (a == 3)
{
    Console.WriteLine("Сегодня среда.Еще три дня до выходного");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг.Еще два дня до выходного");
}
else if (a == 5)
{
    Console.WriteLine("Сегодня пятница.Ура еще один выходного");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня суббота это выходной день");
}
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье это выходной день");
}
else 
{
    Console.WriteLine("Нет такого дня недели");
}