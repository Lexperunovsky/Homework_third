//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int num;
while (true)
{

Console.WriteLine("Введите пятизначное число: ");
try 
{
    num = Convert.ToInt32(Console.ReadLine());
    break;
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода! {exc.Message}");
}
}
if (num < 99999)
{
    int forthNumber = num % 100 /10;
    int fifthNumber = num % 10;
    
   Console.WriteLine($"пятое число ={fifthNumber}, четветое число = {forthNumber}");
}
if (num < 99999)
{
    int firstNumber = num / 10000;
    int secondNumber = num / 1000 % 10;
   Console.WriteLine($"первое число ={firstNumber}, второе число = {secondNumber}");
}









/*int num;
while (true)
{

Console.WriteLine("Введите целое число: ");
try 
{
    num = Convert.ToInt32(Console.ReadLine());
    break;
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода! {exc.Message}");
}
}
//int num_abs = Math.Abs(num);
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
int thirdNumberRight = num / 100 % 10;

while (num > 999)
{
num /= 10;
}
int thirdNumberLeft = num % 10;
Console.WriteLine($"Третья цифра числа {num} справа = {thirdNumberRight}");
Console.WriteLine($"Третья цифра числа {num} слева = {thirdNumberLeft }");*/