// Задача 23
// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// int i=1;
// while (i<=N)
// {
//     Console.Write(Math.Pow (i,3)+ "\t");
//     i++;
// }

// Задача 21
// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату точки А по оси Х: ");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси Y: ");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси Z: ");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Х: ");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Y: ");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки B по оси Z: ");
// int z2=Convert.ToInt32(Console.ReadLine());
// // AB=√(x2-x1)2+(y2-y1)2+(z2-z1)2
// double result=Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
// Console.WriteLine(Math.Round(result,2));


// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром");
    }

    else
    {
        Console.WriteLine(number + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}
