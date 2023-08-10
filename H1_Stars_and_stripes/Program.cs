namespace H1_Stars_and_stripes
{
    internal class Program
    {
        static void Main()
        {
            bool isRed = true;
            int redCounter = 0;

            Console.ForegroundColor = ConsoleColor.White;

            for(int i = 0; i < 26;  i++)
            {

                if (i == 0)
                {
                    // without stars

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("                       ");
                    if(isRed)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("               ");
                } 
                else if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                {
                    // Blue with stars, type 1

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(" *   *   *   *   *   * ");
                    if (isRed)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("               ");
                }
                else if (i == 2 || i == 4 ||i == 6 || i == 8 ||i == 10)
                {
                    // Blue with stars, type 2
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("   *   *   *   *   *   ");
                    if (isRed)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("               ");
                }
                else if (i > 10)
                {
                    // only white or red
                    if (isRed)
                        Console.BackgroundColor = ConsoleColor.Red;
                    else
                        Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("                                      ");
                }

                Console.WriteLine();

                if (isRed)
                {
                    redCounter++;

                    if (redCounter == 2)
                    {
                        isRed = false;
                        redCounter = 0;
                    }
                }
                if (!isRed)
                {
                    redCounter++;

                    if (redCounter == 3)
                    {
                        isRed = true;
                        redCounter = 0;
                    }
                }
            }
        }
    }
}