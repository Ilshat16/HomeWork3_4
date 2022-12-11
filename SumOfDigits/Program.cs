//Напишите программу, которая принимает на вход число
//и выдает сумму цифр в числе

//Метод для вычисления суммы цифр в числе
int SumOfDigit(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
//Метод для ввода данных
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Ввод данных
int number = EnterData("Введите число: ");
//Тело программы
int result = SumOfDigit(number);
//Вывод результата
Console.WriteLine($"Сумма цифр в числе {number} равна: {result}");