// Напишите программу, которая на вход принимает число (A) и выдает сумму чисел от 1 до А

void f(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum+=i;
    }
    Console.Write(sum);
}

Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
f(n);