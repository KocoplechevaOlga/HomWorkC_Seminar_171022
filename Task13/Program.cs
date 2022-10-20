// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

int ThirdDig (int N)
{
    if (N < 100) Console.WriteLine("В заданном числе отсутсвует третья цифра");

    else
    {
        while (N >= 1000)
            {
                N = N / 10;
            }
        Console.WriteLine($"Третья цифра заданного числа: {N % 10}");
    }

    return N;
}

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());


int hirdDigit = ThirdDig(number);