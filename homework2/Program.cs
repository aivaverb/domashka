/* ЗАДАЧА 10.
Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.*/
/*
int SecondNum(int num)
{
    int num = num / 10 % 10;
    return num;
}

Console.WriteLine("введи трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int secnum = SecondNum(num);

Console.WriteLine($"вторая цифра числа {num} - {secnum}");*/

/*Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/
/*
int ThirdNum(int num)
{   
    while (num > 999)
    {
        num /= 10;
    }
    return num;
}  

Console.Write("введите число: ");
int usernum = Convert.ToInt32(Console.ReadLine());
int digit = ThirdNum(usernum);

if (digit > 99) Console.WriteLine($"третья цифра из числа {usernum} - {digit % 10}");

if (digit < 100) Console.WriteLine("третьей цифры нет!");
*/

/*ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

/*Console.Write("введите число дня недели: ");
int usernum = Convert.ToInt32(Console.ReadLine());
if (usernum <= 5) Console.WriteLine("рабочий");
if (usernum > 5 & usernum <= 7) Console.WriteLine("выходной");
if (usernum >7) Console.WriteLine("в неделе всего 7 дней"); */



