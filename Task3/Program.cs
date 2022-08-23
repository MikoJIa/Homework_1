// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка). 4 -> Четное

int Prompt(string message)
{
    System.Console.Write(message);         // Вывести сообщение
    string readValue = Console.ReadLine(); // Считывает с консоли строку
    int result = int.Parse(readValue);     // Преобразует строку в целое число
    return result;                         // Возвращает результат 
}

int a;
a = Prompt("Введите число >");
if (a % 2 == 0){
    System.Console.WriteLine("Число является чётным!");
}else{
    System.Console.WriteLine("Число является не чётным!");
}