int a = 0;
int n = new int();
Console.WriteLine("Введите число");
n = Convert.ToInt32(Console.ReadLine());
while (a < (n -1))
{
    a += 2;
    Console.WriteLine(a);
}
Console.Write("Четные числа от 1 до введеного числа");


