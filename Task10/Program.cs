// 1. принимает на вход трёхзначное число
//2. на выходе показывает вторую цифру этого числа.
// Например: 456 -> 5, 782 -> 8, 918 -> 1

int SecondDigit (int Number)
{
    int SecDig = Number % 100 / 10;
    return SecDig;
}

Console.WriteLine("Введите целое трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int resalt = SecondDigit (Num);
Console.WriteLine(resalt);
