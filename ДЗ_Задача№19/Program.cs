Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int i = 0;
if (num[i] == num[num.Length-i-1])
{
    Console.WriteLine("является полидромом!");
}
else
{
    Console.WriteLine("не является полидромом!");
}
i++;  
