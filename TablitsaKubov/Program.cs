// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число = ");
int b = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index<=b)
{
    Console.Write($"{Cubes(index)}  ");
    index++;
}

int Cubes(int x)
{
    return x*x*x;
}

