//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);

while (num > 999)
{
    num = num / 10;
}
if (num < 99)
{
    Console.WriteLine($"Третьей цифры нет"!);
}
else
{
    num = num % 10;
    Console.WriteLine($"{num}"!);
}





