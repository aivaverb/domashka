﻿/*int[,] createRandom(int str, int stolb, int min, int max) 
{
    int[,] newArray = new int[str, stolb];

    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            newArray[i, j] = new Random().Next(min,max);
        }
    }
    return newArray;

}
*/
void showArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] +" ");
        }
        Console.WriteLine();

    }
}
/*
Console.Write("сколько строк: ");
int str = Convert.ToInt32(Console.ReadLine());

Console.Write("сколько столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());

Console.Write("минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

/*int[,] arr = createRandom(str, stolb, min, max);
showArray(arr);*/

/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. 
Выведите полученный массив на экран.*/
/*
int[,] newar(int str, int stolb, int min, int max) 
{
    int[,] newArray = new int[str, stolb];

    for(int i = 0; i < str; i++)
    {
        for(int j = 0; j < stolb; j++)
        {
            newArray[i, j] = i + j;
        }
    }
    return newArray;

}
*/
/*
int[,] ar = newar(str, stolb, min, max);
showArray(ar);*/

/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/
/*
int[,] chetnkvadr(int[,] array)
{
    //int[,] arr = new int[str, stolb];
    
        for(int i = 0; i < array.GetLength(0); i++)
        {    for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = i + j;
            }
        }    
    
    return array;
}
*/
/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/
/*
int[,] chetnkvadr(int[,] array)
{
    
        for(int i = 0; i < array.GetLength(0); i+=2)
        {    for(int j = 0; j < array.GetLength(1); j+=2)
            {
                array[i, j] = i + j * array[i, j];
            }
        }    
    
    return array;
}
*/

/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.*/
/*
int arraySum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1); j+=2)
        {
            sum = array[i, j] + sum;
        }
    }
    return sum;
}
*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

int[,] myArray(int m, int n, int min, int max)
{
    int[,] newArray = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newArray[i, j] = new Random().Next(min, max);
        }
    }
    return newArray;
}

Console.Write("введи минимальное число; ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("введи максимальное число; ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("введи число строк; ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введи число столбцов; ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = myArray(m, n, min, max);
showArray(arr);


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:*/
/*
bool proverkaMacciva(int[,] array, int m)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == m || j == m) return true;
            
        }  
    }
    return false;

}

Console.Write("введи число которое нужно найти: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(proverkaMacciva(arr, m));
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.*/

double[] sredneeArifm(int[,] array)
{
    double[] stolbec = new double [array.GetLength(1)];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {          
           stolbec[j] += Convert.ToDouble(array[i,j]); 
           
        }
    }
    for(int i = 0; i < stolbec.Length; i++)
    {
        stolbec[i] /= array.GetLength(0);
    }
    
    return stolbec;
}

double[] arik = sredneeArifm(arr);

void showmassiv(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
showmassiv(arik);


