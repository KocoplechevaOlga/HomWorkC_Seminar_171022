// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// Например:   6 -> да, 7 -> да,1 -> нет

bool FindWeekEnd (int N)
{
    if (N ==6 || N == 7) return true;
    return false;
}

Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 1 && n < 7) 
 {
    bool result = FindWeekEnd (n);
    if (result)
    {
    Console.WriteLine($"{n}  ->  Да");
    }
    else
    {
    Console.WriteLine($"{n}  ->  Нет");
    }
 }
else
{
    Console.WriteLine("Введенное число не соответствует дню недели, ввидете число от 1 до 7");
}
