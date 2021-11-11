
Console.WriteLine("Угадай число от 1 до 100 У вас 5 попыток");
int a = new Random().Next(1, 100);
int atempt = 7;
int count = 0;
Console.Write("Введите число :");
int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < atempt; i++)
{
    count++;

    if (userNumber > a)
    {
        Console.WriteLine("Много");
    }
    else if (userNumber < a)
    {
        Console.WriteLine("Мало");
    }
    else if (userNumber == a)
    {
        Console.WriteLine($"Вы угадали за {count} попыток !");
        break;
    }

    Console.Write("еще раз : ");
    userNumber = Convert.ToInt32(Console.ReadLine());
}
if (a != userNumber)
{
    Console.WriteLine("Вы не угадали !");
}