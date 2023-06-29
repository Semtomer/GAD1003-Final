
namespace FinalProject
{
    public class horseRace
    {
        public static Random rand = new Random();

        public static int horseDecision()
        {
            bool again = false;
            do
            {
                try
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           BOLD PILOT --> 1.5  odds --> for press 1                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           AVATAR     --> 3    odds --> for press 2                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           ACAR HATUN --> 2.25 odds --> for press 3                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           ATMACA     --> 1.75 odds --> for press 4                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           ÇAKIR      --> 2    odds --> for press 5                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           KOCA BABA  --> 2.5  odds --> for press 6                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           TURBO      --> 2.75 odds --> for press 7                           ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                           KARABERK   --> 3.25 odds --> for press 8                           \n");

                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                                   Press the number which horse do you want to place a bet?                   \n");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("                                      If you want to leave The Ganyan Dealer, press 9... ");
                    int horseDecision = Convert.ToInt32(Console.ReadLine());

                    if (horseDecision == 1)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                              You made your choice to the Bold Pilot, your devil be plentiful :)              \n");
                        Console.WriteLine("                                                                    _________ _______________                 ");
                        Console.WriteLine("                                                                    _________|    _     _    |                ");
                        Console.WriteLine("                                                                    _________|   (_)   (_)   |                ");
                        Console.WriteLine("                                                                    _________|    _______    |                ");
                        Console.WriteLine("                                                                             |   |_______|   |                ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                 ____________________________________________|               |                ");
                        Console.WriteLine("                                |               |                                            |                ");
                        Console.WriteLine("                                |_______________|                                            |                ");
                        Console.WriteLine("                                                |                BOLD PILOT                  |                ");
                        Console.WriteLine("                                                |                                            |                ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                |    _______    ________    ______    _______|                ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |   |      |   |       |   |      |   |                       ");
                        Console.WriteLine("                                                |___|      |___|       |___|      |___|                       \n");
                        return 1;
                    }
                    else if (horseDecision == 2)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                 You made your choice to the Avatar, your devil be plentiful :)               \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                  AVATAR                    |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 2;
                    }
                    else if (horseDecision == 3)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                               You made your choice to the Acar Hatun, your devil be plentiful :)             \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                ACAR HATUN                  |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 3;
                    }
                    else if (horseDecision == 4)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                 You made your choice to the Atmaca, your devil be plentiful :)               \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                  ATMACA                    |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 4;
                    }
                    else if (horseDecision == 5)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                  You made your choice to the Çakır, your devil be plentiful :)               \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                   ÇAKIR                    |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 5;
                    }
                    else if (horseDecision == 6)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                You made your choice to the Koca Baba, your devil be plentiful :)             \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                 KOCA BABA                  |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                     \n");
                        return 6;
                    }
                    else if (horseDecision == 7)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                  You made your choice to the Turbo, your devil be plentiful :)               \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                   TURBO                    |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 7;
                    }
                    else if (horseDecision == 8)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                                You made your choice to the Karaberk, your devil be plentiful :)              \n");
                        Console.WriteLine("                                                                     _________ _______________                ");
                        Console.WriteLine("                                                                     _________|    _     _    |               ");
                        Console.WriteLine("                                                                     _________|   (_)   (_)   |               ");
                        Console.WriteLine("                                                                     _________|    _______    |               ");
                        Console.WriteLine("                                                                              |   |_______|   |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  ____________________________________________|               |               ");
                        Console.WriteLine("                                 |               |                                            |               ");
                        Console.WriteLine("                                 |_______________|                                            |               ");
                        Console.WriteLine("                                                 |                 KARABERK                   |               ");
                        Console.WriteLine("                                                 |                                            |               ");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                                 |    _______    ________    ______    _______|               ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |   |      |   |       |   |      |   |                      ");
                        Console.WriteLine("                                                 |___|      |___|       |___|      |___|                      \n");
                        return 8;
                    }
                    else if (horseDecision == 9)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                           You left the Ganyan dealer and walked towards the center of UMUT BET CENTER.       \n");
                        return 9;
                    }
                    else
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  Please press in one of the numbers between 0 and 10 numbers.                \n");
                        again = true;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(0);
                    Console.WriteLine("                   You entered the invalid input. Please press in one of the numbers between 0 and 10 numbers.\n");
                    again = true;
                }
            } while (again);

            return 0;
        }
        public static void rankingResult(int HorseDecision, float AskBet)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n                                                 Horses are ready for the race.                               \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                                     The countdown begins...                                  \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                                                3                                             ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                                2                                             ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                                1                                             \n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                 Race started. After 5 seconds, the race winner will be announced.            \n");
            System.Threading.Thread.Sleep(5000);

            int[] participations = new int[255] { 1, 7, 4, 1, 4, 1, 1, 1, 4, 4, 4, 4, 1, 1, 1, 4, 1, 1, 6, 4, 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 3, 1, 5, 1, 5, 1, 4, 1, 1, 4, 1, 4, 1, 5, 3, 3, 1, 4, 4, 4, 1, 5, 1, 1, 4, 1, 1, 1, 5, 1, 4, 1, 7, 6, 4, 1, 5, 1, 1, 7, 5, 1, 1, 1, 4, 1, 4, 6, 4, 4, 1, 1, 4, 4, 1, 1, 1, 4, 4, 4, 4, 4, 1, 1, 1, 1, 4, 1, 4, 1, 4, 5, 1, 5, 5, 3, 1, 1, 5, 1, 1, 4, 1, 5, 4, 1, 5, 1, 1, 1, 4, 1, 4, 1, 1, 1, 5, 1, 1, 5, 5, 1, 4, 4, 5, 1, 1, 4, 1, 3, 1, 1, 6, 4, 1, 4, 4, 1, 3, 1, 1, 4, 1, 1, 4, 5, 1, 4, 4, 4, 5, 4, 5, 6, 1, 1, 3, 4, 1, 5, 8, 1, 1, 1, 1, 1, 4, 1, 4, 1, 1, 1, 3, 1, 1, 1, 1, 4, 4, 4, 1, 4, 7, 1, 1, 5, 5, 5, 1, 2, 5, 1, 1, 5, 1, 1, 1, 1, 1, 4, 2, 3, 1, 4, 1, 1, 1, 1, 3, 4, 1, 1, 3, 3, 1, 3, 5, 3, 5, 1, 4, 3, 6, 1, 1, 4, 1, 5, 4, 1, 1, 5, 5, 4, 4, 4, 1, 4, 6, 5 };
            int pick = rand.Next(0, participations.Length);

            if (HorseDecision == participations[pick])
            {
                winRace(HorseDecision, AskBet);
            }
            else if (HorseDecision != participations[pick])
            {
                loseRace(HorseDecision);
            }
        }
        public static void winRace(int HorseDecision, float AskBet)
        {
            if (HorseDecision == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                    Bold Pilot ran in its form as usual and took first place.                 \n");
                General.credit += AskBet * 1.5f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("           By not letting down its supporters, Avatar did perhaps the best run of its life and came first in the race.\n");
                General.credit += AskBet * 3;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Acar Hatun did not give up until the end of the race and with its last attack, it passed the Bold Pilot and Atmaca and became the first.\n");
                General.credit += AskBet * 2.25f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                      Atmaca ran in its form as usual and took first place.                 \n");
                General.credit += AskBet * 1.75f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Çakır did not give up until the end of the race and with its last attack, it passed the Bold Pilot and Atmaca and became the first.\n");
                General.credit += AskBet * 2;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Koca Baba did not give up until the end of the race and with its last attack, it passed the Bold Pilot and Atmaca and became the first.\n");
                General.credit += AskBet * 2.5f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("            By not letting down its supporters, Turbo did perhaps the best run of its life and came first in the race.\n");
                General.credit += AskBet * 2.75f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
            else if (HorseDecision == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("          By not letting down its supporters, Karaberk did perhaps the best run of its life and came first in the race.\n");
                General.credit += AskBet * 3.25f;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            }
        }
        public static void loseRace(int HorseDecision)
        {
            if (HorseDecision == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                      Bold Pilot could not catch its form because it was rainy and it lost the first place.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("        By letting down its supporters, Avatar did perhaps the worst run of its life and did not come first in the race.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("           Although Acar Hatun did not give up until the end of the race, it could not pass the Bold Pilot and Atmaca.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                               Atmaca was not in its form today and did not catch the first place.            \n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("             Although Çakır did not give up until the end of the race, it could not pass the Bold Pilot and Atmaca.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("           Although Koca Baba did not give up until the end of the race, it could not pass the Bold Pilot and Atmaca.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("         By letting down its supporters, Turbo did perhaps the worst run of its life and did not come first in the race.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (HorseDecision == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("       By letting down its supporters, Karaberk did perhaps the worst run of its life and did not come first in the race.\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public static Tuple<bool, bool> wantToContinue(bool lobbyAgain, bool horseRaceAgain)
        {
            bool continueAgain = false;

            do
            {
                System.Threading.Thread.Sleep(500);
                Console.Write("\n                                       Do you want to continue playing horse racing?(Y/N) ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y" || answer == "yes")
                {
                    Console.Clear();
                    lobbyAgain = false;
                    horseRaceAgain = true;
                    continueAgain = false;
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                         You left the Ganyan dealer and walked towards the center of UMUT BET CENTER.         \n");
                    lobbyAgain = true;
                    horseRaceAgain = false;
                    continueAgain = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                                Please just type 'Yes' or 'No'.                               ");
                    continueAgain = true;
                }
            } while (continueAgain);

            return Tuple.Create(lobbyAgain, horseRaceAgain);
        }
    }
}