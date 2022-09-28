/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
             числами. Напишите программу, которая покажет количество чётных 
             чисел в массиве.*/

/*int[] randomArray(int size, int min, int max)

{
    int[] myArray = new int[size];
    for(int i =0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max +1);
    }
    return myArray;

}

void showAr(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int evenNum(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even = even + 1;
    } 
    
    return even;
    
}

int[] newArray = randomArray(5, 100, 999);
showAr(newArray);
Console.WriteLine($"количество чётных чисел в массиве " + evenNum(newArray));
evenNum(newArray); */

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
             стоящих на нечётных позициях.*/

/*
int[] randomArray(int size, int min, int max)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max + 1);
    }
    return myArray;
}

void showAr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int pozicii(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summa += array[i];
    }
    return summa;
}


int[] newArray = randomArray(5, 0, 10);
showAr(newArray);
Console.WriteLine(pozicii(newArray));
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
             элементов массива.*/

int max (int[] array)
{ 
    int max = 0;   
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];             
        }
    }
    return max;
}    

int min(int[]array)
{
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}


int[] ar = new int[]{1,7,3,4,6};
int result = max(ar) - min(ar);

Console.WriteLine($"максимальное число в массиве - {max(ar)}");
Console.WriteLine($"минимальное число в массиве - {min(ar)}");
Console.WriteLine($"разница - {result}");
/* Здравствуйте, Павел!
У меня вопрос? Хотела, в один метод записать и мин и мах и result, не получилось.
Скажите это возможно?*/
