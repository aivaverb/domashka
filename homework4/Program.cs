/*Задача 25: Напишите цикл, который принимает на вход два числа (num и B) и возводит 
             число num в натуральную степень B. */

/*Console.WriteLine("введите два числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int stepen = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32 (Math.Pow(num, stepen));
Console.WriteLine(result); */
/*
int Stepen(int num, int b)
{
    int result = 1;
     
    for(int i = 0; i < b;)
    {
        result = num * result;
        i++;
    }
    
   return result;
}
Console.Write("введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("введи степень в которую хочешь возвести первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = Stepen(num,b);
Console.WriteLine($"{num} в степени {b} равно: {stepen} "); */
 
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
             сумму цифр в числе.*/

/*int summ(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num /10 ;
    } 
    return sum;
}
Console.Write("введите число: ");
int sum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр вашего числа равна: {summ(sum)}");*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
             выводит их на экран.*/


int[] randomArray(int size, int min, int max)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

void showAr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", " );
    }
    Console.WriteLine();
}


int[] newArray = randomArray(8, 0, 10);
showAr(newArray);