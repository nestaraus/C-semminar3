Console.Clear();
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n<100)
    Console.Write("Третьей цифры нет");
else
{
    while (n>999)
    {
        n/=10;
    }
    Console.Write(n%10);
}