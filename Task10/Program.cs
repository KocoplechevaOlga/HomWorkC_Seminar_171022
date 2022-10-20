// 1. принимает на вход трёхзначное число
//2. на выходе показывает вторую цифру этого числа.
// Например: 456 -> 5, 782 -> 8, 918 -> 1

int SecondDigit (int Number)
{
    int SecDig = Number % 100 / 10;
    return SecDig;
}

Console.WriteLine("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
int resalt = SecondDigit (num);
Console.WriteLine(resalt);
}