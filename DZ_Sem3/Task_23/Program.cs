// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

int N = 1;

while (N <= numberN)
{
    Console.WriteLine($"{Math.Pow(N,3)}");
    N = N + 1;
}
