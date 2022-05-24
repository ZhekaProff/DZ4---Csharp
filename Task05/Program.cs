// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

// ====функции====
void PrintArray(int[] array) // функция печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

void RandomArray(int[] array) // заполняем массив рандомными числами 
{
    for(int i = 0; i < array.Length; i++ )
    {
        array[i] = new Random().Next(1, 10);     
    }
}

// решение

int [] array = new int [11];
RandomArray(array);
PrintArray(array);
Console.WriteLine();

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)
{   
    if ( i == j) break;
    Console.Write($" {array[i] * array[j]} ");
    j--;
}

