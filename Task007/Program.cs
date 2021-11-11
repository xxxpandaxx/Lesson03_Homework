//07 Показать числа от -N до N


void FillArray(int[] array)
{
    int index = 0; 
    int count = array.Length;
    while(index<count)
    {
        array[index] = new Random().Next(-10,10);
        index++;
    }
}

void PrintArray(int[] printArr)
{
    for (int i = 0; i < printArr.Length; i++)
    {
        Console.WriteLine(printArr[i]);
    }
}


int[] numbersN= new int[10];

FillArray(numbersN);

PrintArray(numbersN); 






