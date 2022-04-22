// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// Test 4 -> да? -3 -> нет, 7 -> нет

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if (a % 2 == 0)
{
    Console.WriteLine("ДA");
}
    if (a % 2 != 0)
    {
       Console.WriteLine("НЕТ"); 
    }
 