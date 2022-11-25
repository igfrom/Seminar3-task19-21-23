// **Задача 21:** Напишите программу, которая принимает 
//     на вход координаты двух точек и находит расстояние между ними в 3D
//   пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А: ");
double ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
double ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
double az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B: ");
double bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine(distance);