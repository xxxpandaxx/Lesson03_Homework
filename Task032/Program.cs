// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] arr = new int [8];

for ( int i = 0; i<arr.Length; i++)
{
    arr[i] = 0;
    Console.Write(arr[i] + " : ");
    i++;
    arr[i] = 1;
    Console.Write(arr[i] + " : ");
    if (arr[i] == arr.Length)
    {
        break;
    }
}

