//Напишите программу, которая задает массив из 8 элементов
//и выводит их на экран

//Метод для заполнения массива случайными числами от 1 до 99
void FillArray(int[] array)
{
    int min = 1;
    int max = 99;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
//Создание пустого массива из 8 элементов
int length = 8;
int[] array = new int[length];
//Тело программы
FillArray(array);
//Вывод результата
Console.WriteLine($"[{string.Join(", ", array)}]");