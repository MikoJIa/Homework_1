// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N. 5 -> 2, 4

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int N;
N = Prompt("Введите число N >");
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
