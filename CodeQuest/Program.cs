using System;

public class Program
{
    public static void Main()
    {
        const string AnyKeyContinue = "Press any key to continue";
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        int power, hour, totalpower = 1, op = 0;
        bool validInput;
        string WizardName;

        Random rnd = new Random();

        Console.WriteLine("What's your name, oh destined one?");
        WizardName = Console.ReadLine();

        do
        {
            op = 0;
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine(op);
            }

            if (op == 1)
            {
                for (int i = 1; i < 6; i++)
                {
                    hour= rnd.Next(7,11);
                    power = rnd.Next(11);
                    totalpower = totalpower + power;
                    Console.WriteLine("Dia " + i + ": " + WizardName + ", after meditating for " + hour + " hours, you gained " + power + " points of power, your power is now of " + totalpower + "!" );
                    Console.WriteLine(AnyKeyContinue);
                    Console.ReadLine();
                }

                if (totalpower > 45)
                {
                    Console.WriteLine("You gained the rank 'Arcane Master'!");
                    Console.WriteLine("You gained the title of 'ITB-Wizard the grey'.");
                }
                else if (totalpower > 40)
                {
                    Console.WriteLine("Wow! You can summon dragons without burning the lab!");
                    Console.WriteLine("You gained the title of 'Elarion of the embers'.");
                }
                else if (totalpower > 30)
                {
                    Console.WriteLine("You're a summoner of magic breezes");
                    Console.WriteLine("You gained the title of 'Arka Nullpointer'.");
                }
                else if (totalpower > 20)
                {
                    Console.WriteLine("You still confuse your wand with a spoon.");
                    Console.WriteLine("You gained the title of 'Zyn the bugged one'.");
                }
            }


        } while (op != 0);
    }
}