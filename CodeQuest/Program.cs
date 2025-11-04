using System;

public class Program
{
    public static void Main()
    {
        const string DungeonWin = "You conquered the legendary dragon's dungeon!";
        const string DungeonLost = "The dragon detected your presence and kicked you from the server!";
        const string DungeonWelcome = "Welcome to the dungeon of the legendary dragon: RAMon!";
        const string DungeonDoor = "Get to the treasure, you have {0} door/s left.";
        const string DungeonInput = "Guess the magical password, it must be a value from 1 to 5.";
        const string DungeonLives = "Incorrect, you have {0} lives left.";
        const string AnyKeyContinue = "Press any key to continue";
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a valid number.";
        const string MeditationMessage = "Dia {0} :  {1}, after meditating for {2} hours, you gained {3} points of power, your power is now of {4}!";


        int doorinput = 0,doorpsswd,power,hour,totalpower = 1,op = 0, lives = 3, doors = 3;
        string wizardname;
        string Rank = "";
        string Title = "";
        bool DungeonLose = false;
          
        Random rnd = new Random();

        Console.WriteLine("What's your name, oh destined one?");
        wizardname = Console.ReadLine();
         
        do
        {
            op = 0;
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
            }

            switch (op)
            {
                case 1:
                    for (int i = 1; i < 6; i++)
                    {
                        hour= rnd.Next(7,11);
                        power = rnd.Next(11);
                        totalpower = totalpower + power;
                        Console.WriteLine(MeditationMessage, i, wizardname, hour, power, totalpower);
                        Console.WriteLine(AnyKeyContinue);
                        Console.ReadLine();
                    }
                    switch (totalpower)
                    {
                        case > 45:
                            Rank = ("You gained the rank 'Arcane Master'!");
                            Title = ("You gained the title of 'ITB-Wizard the grey'.");
                            break;
                        case > 40:
                            Rank = ("Wow! You can summon dragons without burning the lab!");
                            Title = ("You gained the title of 'Elarion of the embers'.");
                            break;
                        case > 30:
                            Rank = ("You're a summoner of magic breezes");
                            Title = ("You gained the title of 'Arka Nullpointer'.");
                            break;
                        case > 20:
                            Rank = ("You still confuse your wand with a spoon.");
                            Title = ("You gained the title of 'Zyn the bugged one'.");
                            break;
                    }
                    Console.WriteLine(Rank);
                    Console.WriteLine(Title);
                    break;
                case 2:
                    Console.WriteLine(DungeonWelcome);
                    doors = 3;
                    lives = 3;
                    do
                    {
                        if (lives > 0)
                        {
                            doorpsswd = rnd.Next(0, 6);
                            Console.WriteLine(DungeonDoor, doors);
                            Console.WriteLine(DungeonInput);
                            try
                            {
                                doorinput = Convert.ToInt32(Console.ReadLine());
                                if (doorinput == doorpsswd)
                                {
                                    doors--;
                                    lives = 3;
                                    Console.WriteLine("Correct!");
                                }
                                else
                                {
                                    lives--;
                                    Console.WriteLine(DungeonLives, lives);
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(InputErrorMessage);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(InputErrorMessage);
                            }
                        }
                        else
                        {
                            DungeonLose = true;
                        }
                    } while (doors > 0 && !DungeonLose);
                    if (DungeonLose)
                    {
                        Console.WriteLine(DungeonLost);
                    }
                    else
                    {
                        Console.WriteLine(DungeonWin);
                    }
                break;
            }


        } while (op != 0);
    }
}