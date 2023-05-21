namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool keepPlaying = true;

            while (keepPlaying)
            {
                Random randomNumber1 = new Random();
                int computerNumber1 = randomNumber1.Next(1, 101);
                int tryCounter1 = 1;
                int playerNumber1 = 0;

                Console.WriteLine("Level 1");
                Console.ResetColor();
                while (true)
                {
                    Console.WriteLine("Guess a number (1 - 100): ");
                    Console.ResetColor();

                    string playerInput1 = Console.ReadLine();


                    if (playerInput1 != "end")
                    {
                        bool isValid = int.TryParse(playerInput1, out playerNumber1);

                        if (isValid)
                        {
                            if (playerNumber1 > 100 || playerNumber1 < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Invalid Input.");
                                Console.ResetColor();
                                Console.WriteLine();
                            }
                            else if (playerNumber1 == computerNumber1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("You guessed it!");
                                Console.ResetColor();
                                break;
                            }
                            else if (playerNumber1 > computerNumber1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Too High");
                                Console.ResetColor();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Too Low");
                                Console.ResetColor();
                                Console.WriteLine();
                            }
                        }

                        if (tryCounter1 == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("No more tries.");
                            Console.WriteLine("Game Over");
                            Console.ResetColor();
                            break;
                        }

                        tryCounter1++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (tryCounter1 <= 7 && playerNumber1 == computerNumber1)
                {
                    Random randomNumber2 = new Random();
                    int computerNumber2 = randomNumber2.Next(1, 201);
                    int tryCounter2 = 1;
                    int playerNumber2;

                    Console.WriteLine();
                    Console.WriteLine("Level 2");
                    Console.ResetColor();

                    while (true)
                    {
                        Console.WriteLine("Guess a number (1 - 200): ");
                        Console.ResetColor();

                        string playerInput2 = Console.ReadLine();

                        if (playerInput2 != "end")
                        {
                            bool isValid = int.TryParse(playerInput2, out playerNumber2);

                            if (isValid)
                            {
                                if (playerNumber2 > 200 || playerNumber2 < 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Invalid Input.");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                }
                                else if (playerNumber2 == computerNumber2)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("You guessed it!");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Congratulations! You beat the game!");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (playerNumber2 > computerNumber2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Too High");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Too Low");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                }
                            }

                            if (tryCounter2 == 12)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("No more tries.");
                                Console.WriteLine("Game Over");
                                Console.ResetColor();
                                break;
                            }

                            tryCounter2++;
                        }
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type [yes] to Play Again or [no] to quit: ");
                Console.ResetColor();
                string input = Console.ReadLine();
                Console.WriteLine();
                
                if (input == "no")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Tank you for playing!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}