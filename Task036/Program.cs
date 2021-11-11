// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arr = new int[10];

Random rnd = new Random();
int evenNumbers = 0;
int oddNumbers = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 999);
    Console.Write(arr[i] + " ");
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0 )
    {
        evenNumbers++;
    }
    else
    {
        oddNumbers++;
    }
}

Console.WriteLine($"\nколичество четных чисел : {evenNumbers}");
Console.WriteLine($"количество не четных чисел : {oddNumbers}");













