//06 Выяснить является ли число чётным



Console.Write("Введите число : ");
string? s =Console.ReadLine();
var a =Convert.ToInt32(s);


if ( a%2 == 0)
{
    Console.WriteLine(a +" четное !");
}
else
{
     Console.WriteLine(a +" не четное !");
}
