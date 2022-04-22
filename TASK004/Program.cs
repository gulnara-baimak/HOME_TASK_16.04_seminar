// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.  	
// 456 -> 6 	782 -> 2 	918 -> 8

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x);
if (x >= 100 && x <= 999)
{
    int b = x % 100 % 10;
    int c = b % 100;
    Console.WriteLine(c);
}
else 
{
    Console.WriteLine("Пользователь, ты банан!");
}
