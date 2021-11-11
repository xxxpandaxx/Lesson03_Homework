// 14. Найти третью цифру числа или сообщить, что её нет


int a = Convert.ToInt32(Console.ReadLine());

if (a <= 1000 && a >= 100)
{
    a = a % 10;
    Console.WriteLine(a);

}
else
{
    Console.WriteLine("Number out of range ERROR !");
}











