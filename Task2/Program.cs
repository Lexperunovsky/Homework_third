int x,y,z,x1,y1,z1;

    try {
        Console.WriteLine("Введите координаты оси X (A) : ");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
    z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты оси Y (B): ");
    x1 = Convert.ToInt32(Console.ReadLine());
    y1 = Convert.ToInt32(Console.ReadLine());
    z1 = Convert.ToInt32(Console.ReadLine());
    }   
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода{exc.Message}");
        return;
    }

    double result = (Math.Sqrt(Math.Pow(x1 - x,2) + (Math.Pow(y1 - y, 2) +Math.Pow(z1 - z, 2))));
    result = Math.Round(result,2);
    Console.WriteLine($"A({x}, {y}, {z}); B({x1}, {y1}, {z1}) --> {result}");
    
    
