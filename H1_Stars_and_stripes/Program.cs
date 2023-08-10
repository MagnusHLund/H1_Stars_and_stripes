namespace H1_Stars_and_stripes
{
    internal class Program
    {
        static void Main()
        {
            bool isRed = true;
            int redCounter = 0;

            // For loop, which runs 26 times which is the total lines of the height
            for(int i = 0; i < 26;  i++)
            {
                // Checks the value of i and writes the appropriate colors, in the console, based on the isRed value
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

                // Goes to the next line
                Console.WriteLine();

                // Checks if red is true or false
                if (isRed)
                {
                    // Counts up to change the color to white. ++ means +1
                    redCounter++;

                    // if redCounter reaches 2, then it makes isRed false as well as resetting the counter to 0
                    if (redCounter == 2)
                    {
                        isRed = false;
                        redCounter = 0;
                    }
                }
                if (!isRed)
                {
                    // Counts up on the redCounter, by 1
                    redCounter++;

                    // If it reaches 3 then it changes isRed to true
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