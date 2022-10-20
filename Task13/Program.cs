// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number % 10;


if (number < 100) 
{
Console.WriteLine("В заданном числе отсутсвует третья цифра");
}
else
{
    while (count >= 10)
    {
        number = number / 10;
        count = number % 10;
    }
//int resalt = number % 10;
Console.WriteLine("Третья цифра заданного числа: ");
Console.Write(count);
}

