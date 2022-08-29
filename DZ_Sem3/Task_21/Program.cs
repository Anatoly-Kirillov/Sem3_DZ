// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. 
Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c1");
int c1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c2");
int c2 = int.Parse(Console.ReadLine());

int sqr1 = (x1 - x2) * (x1 - x2);
int sqr2 = (y1 - y2) * (y1 - y2);
int sqr3 = (c1 - c2) * (c1 - c2);

int sum = sqr1 + sqr2 + sqr3;

double result = Math.Sqrt(sum);

Console.WriteLine($"{result:f2}");
