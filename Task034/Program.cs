// Написать программу замену элементов массива на противоположные

int[] arr = new int[10];
Random rnd = new Random();
for(int i = 0; i < arr.Length; i++)
{
    arr[i] =rnd.Next(1,10);
    Console.Write(arr[i] + " ");
}

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * - 1;;
    Console.Write( $"| {arr[i]} " );

}



