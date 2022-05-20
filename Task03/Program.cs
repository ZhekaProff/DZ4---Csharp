// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

Console.Clear();
int [] array = new int [5];
int a = 0; // четное
int b = 0; // нечетное
RandomArray(array);
PrintArray(array);
for ( int i = 0; i < array.Length; i++)
{
    if ( array[i] % 2 == 0) 
    a = a + 1;
    else 
    b = b + 1;
    
}
Console.WriteLine();
Console.Write($"Четных: {a} ");
Console.WriteLine();
Console.Write($"Нечетныx: {b} ");


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
        array[i] = new Random().Next(100, 999);     
    }
}


