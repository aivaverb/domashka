
int[,] createRandom(int str, int stolb, int min, int max) 
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
 
Console.Write("сколько строк: ");
int str = Convert.ToInt32(Console.ReadLine());

Console.Write("сколько столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());

Console.Write("минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arr = createRandom(str, stolb, min, max);
showArray(arr);

/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/
/*
int[,] Cutarray(int[,] array)
{
    int iMin = 0, jMin = 0;
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if(i == iMin) i++;
        for(int j = 0, n = 0; j < array.GetLength(1); j++, n++)
        {
            if(j == jMin) j++;
            newArray[m,n] =  array[i,j];
        }
    }
    
return newArray;
}
int[,] ar2 = Cutarray(arr);
showArray(ar2);
*/

/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
если это невозможно, программа должна вывести сообщение для пользователя.*/
/*
int[,] replacemn(int[,] array)
{
    
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            newArray[j,i] = array[i,j];

        
    }
    
return newArray;
}

int[,] ar2 = replacemn(arr);
showArray(ar2);
*/

/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int [,] change(int[,]array)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
        return array;

    }
}



/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.*/


