class SpecialNumber
{
    public static void Main(string[]args)
    {

        int number = int.Parse(Console.ReadLine());

        int originalNum = number;
        bool isSpecial = false;

        while (originalNum > 0)
        {
            int digit = originalNum % 10;

            if (number % digit == 0)
            {
                isSpecial = true;
            }
            else
            {
                isSpecial = false;
                break;
            }
            originalNum /= 10;
        }

        if (isSpecial)
        {
                Console.WriteLine($"{number} is special"); 
        }
        else 
        {
                Console.WriteLine($"{number} is not special"); 
        }
    }

    }
