// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string five = Convert.ToString(number);
int index = five.Length;
if (five.Length == 5)
{
    Console.WriteLine("Вы ввели  пятизначное число ");
}
else
{
    Console.WriteLine("ВЫ ВВЕЛИ НЕ ПЯТИЗНАЧНОЕ ЧИСЛО,ПОВТОРИТЕ ПОПЫТКУ");
}

/*if (five[0] == five[4] || five[1] == five[3])
{
    Console.WriteLine($"Введённое число {number} является полиндромом");
}
else
{
    Console.WriteLine($"Введённое число {number} НЕ является полиндромом");
}*/

string Check(string number1)
{
    if (number1[0] == number1[4] || number1[1] == number1[3])
    {
        Console.WriteLine($"Введённое число {number1} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Введённое число {number1} НЕ является полиндромом");
    }
    return number1;
}   
Check(five);
