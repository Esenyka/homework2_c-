Console.Write("Введите цифру, соответствующую дню недели(от 1 до 7) : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 5 && number < 8)
{
    Console.WriteLine("Да");
}
else if (number > 7)
{
    Console.WriteLine("От 1 до 7!!");
}
else
{
    Console.WriteLine("Нет");
}