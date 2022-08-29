// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int num1 = number % 10 * 10000;
int num2 = number / 10 % 10 * 1000;
int num3 = number / 100 % 10 * 100;
int num4 = number / 1000 % 10 * 10;
int num5 = number / 10000;

int result = num1 + num2 + num3 + num4 + num5;

if(result == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}  

    


