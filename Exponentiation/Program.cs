//Напишите цикл, который принимает на вход два числа (А, В)
//и возводит число А в натуральную степень В

//Методы
double Exponentiation(int n1, int n2)
{
    double result = Math.Pow(n1, n2);
    return result;
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Ввод данных
int a = EnterData("Введите число А: ");
int b = EnterData("Введите число B: ");
//Тело программы
double result = Exponentiation(a, b);
//Вывод результата
Console.WriteLine($"А^В = {a}^{b} = {result}");