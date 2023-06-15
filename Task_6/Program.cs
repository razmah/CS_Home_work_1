/* Напишите программу, которая на вход принимает число
и выдает, является ли оно четным (делится ли оно на два без остатка) */

Console.Clear();
Console.Write("Введите число: ");
string input = Console.ReadLine() ?? "";

int Number = int.Parse(input);

if (Number % 2 == 0)
{
    Console.Write($"{Number} - четное");
}
else 
{
    Console.WriteLine($"{Number} - нечетное");
}