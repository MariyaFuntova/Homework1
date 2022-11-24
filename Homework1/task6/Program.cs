int UserNumber = new int();
Console.WriteLine("Введите число");
UserNumber = Convert.ToInt32(Console.ReadLine());
if (UserNumber % 2 == 0)
{
    Console.WriteLine("Да (Число четное)");
}
else
{
    Console.WriteLine("Нет (Число нечетное)");
}

