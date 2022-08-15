
﻿﻿// See https://aka.ms/new-console-template for more information

/*Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine(num_1 + " больше " + num_2);
}
else
{
    Console.WriteLine(num_1 + " мешьше " + num_2);
}*/

// ЗАДАЧА 4

/*int maxnumber;

Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    maxnumber = num_1;
}
else
{
    maxnumber = num_2;
    
}
if (maxnumber < num_3)
{
    maxnumber = num_3;
}

Console.Write(maxnumber);*/

/* ЗАДАЧА 6*/
/*int num;
string result;

Console.Write("Ведите любое число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    result = "число четное";
else
    result = "число не четное";

Console.Write(result);*/

/* ЗАДАЧА 8*/

Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
    
        Console.Write(current + " ");
        current++;
    
}