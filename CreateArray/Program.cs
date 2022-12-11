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
//Метод для ввода данных
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Создание пустого массива из 8 элементов
int length = EnterData("Введите длину массива: ");
int[] array = new int[length];
//Тело программы
FillArray(array);
//Вывод результата
Console.WriteLine($"[{string.Join(", ", array)}]");