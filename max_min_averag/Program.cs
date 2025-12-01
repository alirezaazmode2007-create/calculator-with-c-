for (int i = 1; i < 10; i++)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("do you want to continue?");
    string a = Console.ReadLine().ToLower();
    if (a == "yes")
        {
            i--; 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Enter the number of array elements:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[num1];
            for (i = 0; i < num1; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("inter your number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                num[i] = num2;
            }

            int max = num[0];
            int min = num[0];
            double averag = 0;
//بزرگترین       
            for (i = 0; i < num1; i++)
            {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }

//کوچیک ترین       
            for (i = 0; i < num1; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }

//میانگین       
            for (i = 0; i < num1; i++)
            {
                averag += num[i];
            }

            averag /= num1;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(("array elements:" + num1));
            Console.WriteLine("max:" + (max));
            Console.WriteLine("min:" + (min));
            Console.WriteLine("averag:" + (averag));
        }
    else
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("bye");
        break;
        }
}