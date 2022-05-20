// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива
Console.Clear();
int [] array = new int [12];
int length = array.Length; 
int res = 0;
RandomArray(array);
PrintArray(array);

for (int i = 0; i < length; i++) 
res = res + array [i];

Console.WriteLine();
Console.WriteLine($"Result = {res}");




// ====функции====
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
        array[i] = new Random().Next(0, 9);     
    }
}