// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number <= 99999)
{
    int digit = number / 10000;
    int balance = number % 10;
    if (digit == balance)
    {
        int digit2 = number;
        digit2%=10000;
        digit2 /=1000;
        int balance2 = digit2;
        balance2%=100;
        balance2 /=10; 
        if (digit2 == balance2)
        {
             Console.WriteLine("Число {} является палиндромом", number);
        }
        else
        Console.WriteLine("Число {} не является палиндромом", number);
    }
    else
    Console.WriteLine("Число {} не является палиндромом", number);
}
else
Console.WriteLine("Введите пятизначное чило!!");