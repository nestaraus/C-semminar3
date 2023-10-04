// Напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N

void f(int n, ref int result)
{
    for (int i = 1; i <= n; i++)
    {
        result*=i;
    }

}

Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
f(n,ref result);
Console.Write(result);