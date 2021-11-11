//Найти сумму чисел от 1 до А



int[] arr = new int[50];
arr[0] = 1;

int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 20000);

}



for (int i = 0; i < arr.Length; i++)
{
    sum = arr[i] + sum;
    Console.Write($"{sum} + ");
}