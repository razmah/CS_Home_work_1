/* Напишите программу, которая принимает на вход три числа 
и выдает максимальное из этих чисел */

Console.Clear();
Console.WriteLine($"Введите три числа: ");

string input_1 = Console.ReadLine() ?? "";
string input_2 = Console.ReadLine() ?? "";
string input_3 = Console.ReadLine() ?? "";

int Number_1 = int.Parse(input_1);
int Number_2 = int.Parse(input_2);
int Number_3 = int.Parse(input_3);
int Max = Number_1;

if (Number_2 > Max)
{
    Max = Number_2;
}
if (Number_3 > Max)
{
    Max = Number_3;
}

Console.WriteLine($"Первое число = {Number_1}\nВторое число = {Number_2}\nТретье число = {Number_3}\nMax = {Max}");

