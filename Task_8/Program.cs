/* Напишите программу, которая на вход принимает число (N),
а на выходе показывает все четные числа от 1 до N */

Console.Clear();
Console.Write("Введите число: ");

string input = Console.ReadLine() ?? "";
int N = int.Parse(input);
int index = 1;

while(index <= N)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index} ");
    }
    index++;
}