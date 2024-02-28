// Задача 1. Напишите программу, которая принимает на 
// вход число и проверяет, кратно ли оно одновременно 7 и 23

// System.Console.WriteLine("Введите число - ");
// int i = Convert.ToInt32(Console.ReadLine());
// if (i%7==0 && i%23==0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//    Console.WriteLine("нет"); 
// }


// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер координатной четверти плоскости, в которой находится эта точка.

// пояснения т к я не в курсях была по эти четверти:
// Чтобы определить координатную четверть точки, 
// необходимо сравнить значения координат x и y с нулем. 
// Если значение x и y положительное, то точка находится в первой 
// координатной четверти. Если значение x отрицательное, 
// а значение y положительное, то точка находится во второй четверти
// я скопировала код, потму что затупила с решением

// Console.Write("Введите координаты точки X и Y через пробел:");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
// else
// {
//     Console.WriteLine("Точка находится на оси координат");
// }

// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.


// Console.Write("Введите число из отрезка [10, 99]: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 = num / 10;
// int num2 = num % 10;
// if (num1 > num2)
// {
//     System.Console.WriteLine(num1);
// }
// else
// {
//     System.Console.WriteLine(num2);
// }

// Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.
// сама решила :-)

Console.Write("Введите двузначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10)
{
    Console.WriteLine(num);
}
else
{
    int num1 = num / 10;
    int num2 = num % 10;
    Console.Write(num1);
    Console.Write(",");
    Console.Write(num2);
}
