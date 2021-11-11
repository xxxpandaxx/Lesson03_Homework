//9. Показать последнюю цифру трёхзначного числа

Console.Write("Введите число : ");

int number = Convert.ToInt32(Console.ReadLine());


if (number > 100)
{
    number = number % 10;

    Console.WriteLine(number);
}




