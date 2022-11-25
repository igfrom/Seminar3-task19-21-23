// **Задача 19:** Напишите программу, которая принимает 
//     на вход пятизначное число и проверяет, является ли 
//     оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число для проверки палиндорома ");
string numberA = Console.ReadLine();
int length = numberA.Length;

if (length == 5)
{

    if (numberA[1] == numberA[3] && numberA[0] == numberA[4])
{
    Console.WriteLine("Число является палиндромом");
}
    else
{
    Console.WriteLine("Число не является палиндромом");
}
}
else
{
    Console.WriteLine("Число не пятизначное / Отрицательное");
}