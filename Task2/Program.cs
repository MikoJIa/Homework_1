// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int a;
int b;
a = Prompt("Введите первое число >");
b = Prompt("Введите второе число >");
int max;
int min;

if (a > b)
    max = a; min = b;
{
    System.Console.WriteLine($"Максимальное число = {max}");
    System.Console.WriteLine($"Минимальное число = {min}");
}
else
{
    System.Console.WriteLine($"Максимальное число = {max}");
    System.Console.WriteLine($"Минимальное число = {min}");
}
