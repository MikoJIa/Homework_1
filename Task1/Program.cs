// //  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int num1;
int num2;
int num3;
num1 = Prompt("Введите первое число >");
num2 = Prompt("Введите второе число >");
num3 = Prompt("Введите третье число >");
int max = num1;
if (num1 > num2) max = num1;
if (num2 > num3) max = num2;
if (num3 > num1) max = num3;
if (num2 > num1) max = num2;
if (num3 > num2) max = num3;
{
    System.Console.WriteLine($"Максимальное число {max}");
}
