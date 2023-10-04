// Напишите программу, которая на вход принимает число и выдает количество цифр в этом числе




void f(int n)
{
    int kolvo = 0;
    while (n>0)
    {
        kolvo++;
        n /= 10;

    }
    Console.Write(kolvo);
}
Console.Write("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
f(n);