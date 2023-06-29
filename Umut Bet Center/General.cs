
namespace FinalProject
{
    public class General
    {
        public static float credit = 100.0f;
        public static void Lobby()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                                        UMUT BET CENTER                                       \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                            You have {credit} dollars to start the games.                           \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                                   What do you hope to win ?                                  \n");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                                               |                                              ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                                               |                                              ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                        -----------------------------------------------                       ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                        |                      |                      |                       ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                        |                      |                      |                       ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                       (1)                    (2)                    (3)                      ");
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("                                       HORSE RACE          ROULETTE                 SLOT                      \n");
        }

        public static int gameDecision()
        {
            bool again = false;

            do
            {
                try
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                                      Press the number which game that you want to play...                     \n");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("                                       If you want to leave UMUT BET CENTER, press 4... ");
                    int gameDecision = Convert.ToInt32(Console.ReadLine());

                    if (gameDecision == 1)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                        You entered the Ganyan dealer. Security welcomed you, guided you to place a bet.      \n");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                       /               /|                                     ");
                        Console.WriteLine("                                                       |    _     _    ||                                     ");
                        Console.WriteLine("                                                       |   (_) _ (_)   ||                                     ");
                        Console.WriteLine("                                                       |      |_|      ||                                     ");
                        Console.WriteLine("                                                       |     _____     ||                                     ");
                        Console.WriteLine("                                                       |    |_____|    ||                                     ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                     __________________|_______________||__________________                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |            SECURITY              |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |___|    |__________________________________|    |___|                   \n");
                        return 1;
                    }
                    else if (gameDecision == 2)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                      You have progressed to the roulette table and one of our employees is helping you.      \n");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        Console.WriteLine("                                                        | | | | | | | | |                                     ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                       /               /|                                     ");
                        Console.WriteLine("                                                       |    _     _    ||                                     ");
                        Console.WriteLine("                                                       |   (_) _ (_)   ||                                     ");
                        Console.WriteLine("                                                       |      |_|      ||                                     ");
                        Console.WriteLine("                                                       |     _____     ||                                     ");
                        Console.WriteLine("                                                       |    |_____|    ||                                     ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                     __________________|_______________||__________________                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |            EMPLOYEE              |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |   |    |                                  |    |   |                   ");
                        Console.WriteLine("                                     |___|    |__________________________________|    |___|                   \n");
                        return 2;
                    }
                    else if (gameDecision == 3)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                  While walking towards our slot machine, the sounds coming from the slot machine enchant you.          ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                           ___________________________________________________________________________                  ");
                        Console.WriteLine("                          /                                 _____                                    /|                 ");
                        Console.WriteLine("                         /                                 /____/|                                  / |                 ");
                        Console.WriteLine("                        /                                  |____|/                                 /  |                 ");
                        Console.WriteLine("                       /__________________________________________________________________________/   |                 ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                       |                                                                          |   |                 ");
                        Console.WriteLine("                       |                               SLOT MACHİNE                               |   |                 ");
                        Console.WriteLine("                       |                              JACKPOT ON ALL                              |   |                 ");
                        Console.WriteLine("                       |                           AND BET CENTER COMBOS                          |   |                 ");
                        Console.WriteLine("                       |        __________________________________________________________        |   |                 ");
                        Console.WriteLine("                       |       |   _____________   |   _____________   |   ____________   |       |   |                 ");
                        Console.WriteLine("                       |       |  |             |  |  |             |  |  |            |  |       |   |                 ");
                        Console.WriteLine("                       |       |  |     $10     |  |  |     $20     |  |  |    $100    |  |       |   |                 ");
                        Console.WriteLine("                       |       |  |_____________|  |  |_____________|  |  |____________|  |       |   |                 ");
                        Console.WriteLine("                       |       |___________________|___________________|__________________|       |   |                 ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                       |       |   _____________   |   _____________   |   ____________   |       |   |                 ");
                        Console.WriteLine("                       |  PLAY |  |             |  |  |             |  |  |            |  |       |   |      _______    ");
                        Console.WriteLine("                       |  BIG  |  |     UMUT    |  |  |     BET     |  |  |   CENTER   |  |  WIN  |   |     /______/    ");
                        Console.WriteLine("                       |       |  |_____________|  |  |_____________|  |  |____________|  |  BIG  |   |    /      /     ");
                        Console.WriteLine("                       |       |___________________|___________________|__________________|       |   |   /______/      ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                       |       |   _____________   |   _____________   |   ____________   |       |   |    / /          ");
                        Console.WriteLine("                       |       |  |             |  |  |             |  |  |            |  |       |   |   / /           ");
                        Console.WriteLine("                       |       |  |      $5     |  |  |      $1     |  |  |     $50    |  |       |   |  / /            ");
                        Console.WriteLine("                       |       |  |_____________|  |  |_____________|  |  |____________|  |       |   | / /             ");
                        Console.WriteLine("                       |       |___________________|___________________|__________________|       |   |/ /              ");
                        Console.WriteLine("                       |__________________________________________________________________________|   / /               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                       /                                                                          /  / /                ");
                        Console.WriteLine("                      /                                                                          /  / /                 ");
                        Console.WriteLine("                     /                                                                          /  / /|                 ");
                        Console.WriteLine("                    /                                                                          /  / / |                 ");
                        Console.WriteLine("                   /                                                                          /  / /  |                 ");
                        Console.WriteLine("                  /__________________________________________________________________________/  / /   |                 ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                  |                                                                          |  |/    |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                                                                          |        |                 ");
                        Console.WriteLine("                  |                             UMUT BET CENTER                              |        /                 ");
                        Console.WriteLine("                  |                                                                          |       /                  ");
                        Console.WriteLine("                  |                                                                          |      /                   ");
                        Console.WriteLine("                  |                                                                          |     /                    ");
                        Console.WriteLine("                  |                                                                          |    /                     ");
                        Console.WriteLine("                  |                                                                          |   /                      ");
                        Console.WriteLine("                  |                                                                          |  /                       ");
                        Console.WriteLine("                  |                                                                          | /                        ");
                        Console.WriteLine("                  |__________________________________________________________________________|/                         ");
                        System.Threading.Thread.Sleep(7500);
                        return 3;
                    }
                    else if (gameDecision == 4)
                    {
                        return 4;
                    }
                    else
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                        Please press in one of the numbers 1, 2, 3 or 4.                      \n");
                        again = true;
                    }

                }
                catch (FormatException)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                        You entered the invalid input. Please press in one of the numbers 1, 2, 3 or 4.       \n");
                    again = true;
                }
            } while (again);

            return 0;

        }

        public static float askBet()
        {
            bool again = false;
            float bet;

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                              You have {credit} dollars to place a bet.                         \n");

            do
            {
                if (credit == 0)
                {
                    bet = 0;
                    continue;
                }
                System.Threading.Thread.Sleep(500);
                Console.Write("                                            How much do you want to bet on this odd? ");

                while (!float.TryParse(Console.ReadLine(), out bet))
                {
                    System.Threading.Thread.Sleep(250);
                    Console.Write("\n                           You entered the invalid input. Please press the numbers to bet on this odd. ");
                }

                if (bet > credit)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                              You tried to make more money than you have, don't do it, we'll burn.            \n");
                    again = true;
                    continue;
                }
                else if (bet <= 0)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                                  You can't fool the system :(                                \n");
                    again = true;
                    continue;
                }
                again = false;
            } while (again);

            credit -= bet;
            return bet;
        }
    }
}