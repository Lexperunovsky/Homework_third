//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int n;
try
{
Console.WriteLine("Введите любое целое число от 0 до 100: ");
n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода {exc.Message}");
    return;
}
double number = n;
while (number <= 10)
{
    number = number / 10;
    number++;
    Console.WriteLine($"{number}");
    
   
}

double number_cubed = Math.Pow(n,3);
Console.WriteLine($"числ {n} в кубе = {number_cubed}");
