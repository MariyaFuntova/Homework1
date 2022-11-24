int number1 = new int();
Console.WriteLine("Введите число");
number1 = Convert.ToInt32(Console.ReadLine());
int number2 = new int();
Console.WriteLine("Введите число");
number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Большее число");
    Console.WriteLine(number1);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("Большее число");
    Console.WriteLine(number2);
    Console.WriteLine("Меньшее число");
    Console.WriteLine(number1);
}
