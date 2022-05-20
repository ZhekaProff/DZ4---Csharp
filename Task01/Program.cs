// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
void PrintArray(int[] array) // функция печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

void RandomArray(int[] array) // заполняем массив рандомными числами 
{
    int length = array.Length; // определяем длинну массива
    for(int i = 0; i < length; i++ )
    {
        array[i] = new Random().Next(0, 2);     
    }
}
//========================Решение=============================

int [] array = new int [8];
RandomArray(array);
PrintArray(array);
