/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
             больше 0 ввёл пользователь.*/

/*
int[] myAr(int size)
{
    int[] myArray = new int[size];
    
    for(int i = 0; i < myArray.Length; i++)
        {
        Console.Write($"Введите число: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        
    return myArray;

} 

int[] showar(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine((array[i]) +" ");
    }
    return array;
}

int posiv(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        pos = pos + 1;
    }
    return pos;
}
Console.Write("введи размер массива: ");
int num = Convert.ToInt32(Console.ReadLine()); // размер массива
int[] array = myAr(num);
int pos = posiv(array);
showar(array);
Console.Write($"кол-во положительных цифр - {pos} ");*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
           y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("введи значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введи значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());   
Console.Write("введи значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введи значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x) + b1;
 Console.WriteLine($"({x}:{y})");