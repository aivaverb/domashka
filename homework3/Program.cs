/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

/*
string polidrom(int num)
{
    string a = Convert.ToString(num);
    string b = new(a.ToCharArray().Reverse().ToArray());
    if (a == b) return "полидром";
    else return "обычное число";
}     

Console.Write("введи трехзначное число: ");
int usernum = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(polidrom(usernum));
Console.WriteLine(a);
*/

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.*/
/*
double distanse(double xa,double xb, double ya, double yb, double za, double zb)
{
    double distance = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));
    return distance;
}

Console.WriteLine("введи координаты двух точек и я рассчитаю расстояние между ними");
Console.WriteLine("введи координаты точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи координаты точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

double a = distanse(xa, xb, ya, yb, za, zb);
Console.WriteLine($"расстояние между точками равно: {a}");
*/


/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.*/

void Kub(int num)
{
    int i = 1;
    while (i <= num)
    {
        int a = i * i * i;
        Console.Write(a + " ");
        i++;
    }
}

Console.Write("введи число, а я возведу его в куб. ");
int num = Convert.ToInt32(Console.ReadLine());
Kub(num); 
 


   
