// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void RandomArray(int[] array) // заполняем массив рандомными числами 
{
    int length = array.Length; // определяем длинну массива
    for(int i = 0; i < length; i++ )
    {
        array[i] = new Random().Next(0, 100);     
    }
}

int [] array = new int [123];
int a = 0;
RandomArray(array);

for ( int i = 0; i < array.Length; i++)
    if (array[i] > 10 && array[i]< 99) a = a + 1;
Console.Write($"Колличество элеметов: {a} ");    

