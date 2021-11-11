// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int maxNumber = 0;
int[] arr = new int[100];
Random rnd = new Random();
int i = 0;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(1, 100);
    Console.Write(i + ":" + arr[i] + " ");
}
for (i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxNumber)
    {
        maxNumber = arr[i];
    }

}
if (i == arr.Length)
{
    Console.WriteLine($"\n max number = {maxNumber}");
}