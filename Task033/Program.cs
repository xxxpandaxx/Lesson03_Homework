// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] arr = new int[12];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 9);
    Console.Write(" : " + arr[i]);
}
for (int i = 0; i < arr.Length; i++)
{
    sum = sum + arr[i];
}
Console.WriteLine($"\n {sum}");




