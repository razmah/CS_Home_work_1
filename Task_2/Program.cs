/* Напишите программу, которая на вход
принимает два числа и выдает, какое число большее, 
а какое меньшее */

Console.Clear();
Console.Write("Введите первое число: ");
string input_1 = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string input_2 = Console.ReadLine() ?? "";

int FirstNumber = int.Parse(input_1);
int SecondNumber = int.Parse(input_2);
int Max = FirstNumber;

if (SecondNumber > Max)
{
    Max = SecondNumber;
}
else 
    Max = FirstNumber;

Console.WriteLine($"Первое число = {FirstNumber}\nВторое число = {SecondNumber}\nMax = {Max}");
