Console.Write("Введите цифру : ");

string number = Console.ReadLine();
int l = number.Length;

if (l < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
if (Convert.ToInt32(number) < 0)
{
    Console.WriteLine(number[3]);
}
else
{
    Console.WriteLine(number[2]);
}