Console.BackgroundColor = ConsoleColor.Yellow;
    //Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("calculator");
    int num4 = 0;
    do
    {
    
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.DarkRed;
        long num1=Convert.ToInt64(Console.ReadLine());
        char num2=Convert.ToChar(Console.ReadLine());
        long num3=Convert.ToInt64(Console.ReadLine());
    if (num2 =='+') 
    {
        Console.WriteLine("sum="+ (num1+num3));
    }    
    else if (num2 == '-')
    {
        Console.WriteLine("sum="+(num1 - num3));
    }
    else if (num2 == '*')
    {
        Console.WriteLine("sum="+(num1 * num3));
    }
    else if (num2 == '/')
    {
        Console.WriteLine("sum="+ (num1 / num3));
    }

    num4++;
    num4--;
    } while (num4!=2);