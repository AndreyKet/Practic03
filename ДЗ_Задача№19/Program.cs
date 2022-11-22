Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - 1 - i])
    {
        Console.WriteLine("Не является полидромом!");
    }
    else
    {
        Console.WriteLine("Является полидромом!");
    }
}