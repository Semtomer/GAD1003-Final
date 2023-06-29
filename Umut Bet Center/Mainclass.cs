
namespace FinalProject
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            bool lobbyAgain = false;

            do
            {
                General.Lobby();
                int mainGameDecision = General.gameDecision();

                bool horseRaceAgain = false;
                bool rouletteAgain = false;
                bool slotGameAgain = false;

                do
                {
                    if (mainGameDecision == 1)
                    {
                        float beforeYouBet = General.credit;

                        int HorseDecision = horseRace.horseDecision();

                        if (HorseDecision == 9)
                        {
                            lobbyAgain = true;
                            horseRaceAgain = false;
                        }
                        else if (HorseDecision != 9)
                        {
                            float AskBet = General.askBet();
                            horseRace.rankingResult(HorseDecision, AskBet);

                            if (General.credit > beforeYouBet)
                            {
                                Console.WriteLine($"                                          Your earnings from this race is {General.credit - beforeYouBet} dollars.                         ");
                                System.Threading.Thread.Sleep(500);
                            }
                            else if (General.credit < beforeYouBet)
                            {
                                Console.WriteLine($"                                             Your loss on this race is {beforeYouBet - General.credit} dollars.                            ");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("                                             You neither lost nor won on this race.                           ");
                                System.Threading.Thread.Sleep(500);
                            }

                            if (General.credit == 0)
                            {
                                Console.Clear();
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                lobbyAgain = false;
                                horseRaceAgain = false;
                                continue;
                            }

                            Tuple<bool, bool> bringBack = horseRace.wantToContinue(lobbyAgain, horseRaceAgain);
                            lobbyAgain = bringBack.Item1;
                            horseRaceAgain = bringBack.Item2;
                        }
                    }
                } while (horseRaceAgain);

                do
                {
                    if (mainGameDecision == 2)
                    {
                        float beforeYouBet = General.credit;

                        int HowMany;
                        int ChoiceDecision1, ChoiceDecision2, ChoiceDecision3, ChoiceDecision4, ChoiceDecision5, ChoiceDecision6, ChoiceDecision7;
                        int ChoiceDecision8, ChoiceDecision9, ChoiceDecision10, ChoiceDecision11, ChoiceDecision12, ChoiceDecision13;
                        float AskBet1, AskBet2, AskBet3, AskBet4, AskBet5, AskBet6, AskBet7, AskBet8, AskBet9, AskBet10, AskBet11, AskBet12, AskBet13;

                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine($"                                              You have {General.credit} dollars to place a bet.                         \n");
                        System.Threading.Thread.Sleep(500);
                        Console.Write("                                          How many groups of numbers will you bet on? ");

                        while (!int.TryParse(Console.ReadLine(), out HowMany))
                        {
                            System.Threading.Thread.Sleep(500);
                            Console.Write("\n               You entered the invalid input. Please enter the number how many of groups you are going to bet on. ");
                        }

                        if (HowMany == 1)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                       Make your choice.                                      \n");

                            ChoiceDecision1 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                AskBet1 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 2)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                   \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                  \n");
                            ChoiceDecision2 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 3)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                   \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                  \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                   \n");
                            ChoiceDecision3 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 4)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 5)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 6)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 7)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 8)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 9)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your ninth choice.                                  \n");
                            ChoiceDecision9 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14 || ChoiceDecision9 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices9(ChoiceDecision9);
                                AskBet9 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8, ChoiceDecision9, AskBet9);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 10)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your ninth choice.                                  \n");
                            ChoiceDecision9 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your tenth choice.                                  \n");
                            ChoiceDecision10 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14 || ChoiceDecision9 == 14 || ChoiceDecision10 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices9(ChoiceDecision9);
                                AskBet9 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices10(ChoiceDecision10);
                                AskBet10 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8, ChoiceDecision9, AskBet9, ChoiceDecision10, AskBet10);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 11)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your ninth choice.                                  \n");
                            ChoiceDecision9 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your tenth choice.                                  \n");
                            ChoiceDecision10 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your eleventh choice.                                \n");
                            ChoiceDecision11 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14 || ChoiceDecision9 == 14 || ChoiceDecision10 == 14 || ChoiceDecision11 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices9(ChoiceDecision9);
                                AskBet9 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices10(ChoiceDecision10);
                                AskBet10 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices11(ChoiceDecision11);
                                AskBet11 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8, ChoiceDecision9, AskBet9, ChoiceDecision10, AskBet10, ChoiceDecision11, AskBet11);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 12)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your ninth choice.                                  \n");
                            ChoiceDecision9 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your tenth choice.                                  \n");
                            ChoiceDecision10 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your eleventh choice.                                \n");
                            ChoiceDecision11 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your twelfth choice.                                 \n");
                            ChoiceDecision12 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14 || ChoiceDecision9 == 14 || ChoiceDecision10 == 14 || ChoiceDecision11 == 14 || ChoiceDecision12 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices9(ChoiceDecision9);
                                AskBet9 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices10(ChoiceDecision10);
                                AskBet10 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices11(ChoiceDecision11);
                                AskBet11 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices12(ChoiceDecision12);
                                AskBet12 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8, ChoiceDecision9, AskBet9, ChoiceDecision10, AskBet10, ChoiceDecision11, AskBet11, ChoiceDecision12, AskBet12);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else if (HowMany == 13)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your first choice.                                  \n");
                            ChoiceDecision1 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your second choice.                                 \n");
                            ChoiceDecision2 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your third choice.                                  \n");
                            ChoiceDecision3 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fourth choice.                                 \n");
                            ChoiceDecision4 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your fifth choice.                                  \n");
                            ChoiceDecision5 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your sixth choice.                                  \n");
                            ChoiceDecision6 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your seventh choice.                                 \n");
                            ChoiceDecision7 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your eighth choice.                                 \n");
                            ChoiceDecision8 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your ninth choice.                                  \n");
                            ChoiceDecision9 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                    Make your tenth choice.                                  \n");
                            ChoiceDecision10 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your eleventh choice.                                \n");
                            ChoiceDecision11 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                   Make your twelfth choice.                                 \n");
                            ChoiceDecision12 = roulette.choiceDecision();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                                  Make your thirteenth choice.                               \n");
                            ChoiceDecision13 = roulette.choiceDecision();

                            if (ChoiceDecision1 == 14 || ChoiceDecision2 == 14 || ChoiceDecision3 == 14 || ChoiceDecision4 == 14 || ChoiceDecision5 == 14 || ChoiceDecision6 == 14 || ChoiceDecision7 == 14 || ChoiceDecision8 == 14 || ChoiceDecision9 == 14 || ChoiceDecision10 == 14 || ChoiceDecision11 == 14 || ChoiceDecision12 == 14 || ChoiceDecision13 == 14)
                            {
                                lobbyAgain = true;
                                rouletteAgain = false;
                            }
                            else
                            {
                                roulette.showTheChoices1(ChoiceDecision1);
                                AskBet1 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices2(ChoiceDecision2);
                                AskBet2 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices3(ChoiceDecision3);
                                AskBet3 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices4(ChoiceDecision4);
                                AskBet4 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices5(ChoiceDecision5);
                                AskBet5 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices6(ChoiceDecision6);
                                AskBet6 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices7(ChoiceDecision7);
                                AskBet7 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices8(ChoiceDecision8);
                                AskBet8 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices9(ChoiceDecision9);
                                AskBet9 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices10(ChoiceDecision10);
                                AskBet10 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices11(ChoiceDecision11);
                                AskBet11 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices12(ChoiceDecision12);
                                AskBet12 = General.askBet();

                                if (General.credit == 0)
                                {
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("\n                              You could not complete the bet because you did not have money to bet.           \n");
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                                      Your money placed on previous bets will be refunded.                    \n");
                                    General.credit = beforeYouBet;
                                    rouletteAgain = true;
                                    continue;
                                }

                                roulette.showTheChoices13(ChoiceDecision13);
                                AskBet13 = General.askBet();

                                roulette.rouletteResult(ChoiceDecision1, AskBet1, ChoiceDecision2, AskBet2, ChoiceDecision3, AskBet3, ChoiceDecision4, AskBet4, ChoiceDecision5, AskBet5, ChoiceDecision6, AskBet6, ChoiceDecision7, AskBet7, ChoiceDecision8, AskBet8, ChoiceDecision9, AskBet9, ChoiceDecision10, AskBet10, ChoiceDecision11, AskBet11, ChoiceDecision12, AskBet12, ChoiceDecision13, AskBet13);

                                if (General.credit > beforeYouBet)
                                {
                                    Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouBet} dollars.                         ");
                                    System.Threading.Thread.Sleep(500);
                                }
                                else if (General.credit < beforeYouBet)
                                {
                                    Console.WriteLine($"                                            Your loss on this round is {beforeYouBet - General.credit} dollars.                            ");
                                    System.Threading.Thread.Sleep(2000);
                                }
                                else
                                {
                                    Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                    System.Threading.Thread.Sleep(500);
                                }

                                if (General.credit == 0)
                                {
                                    Console.Clear();
                                    System.Threading.Thread.Sleep(500);
                                    Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                    Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                    lobbyAgain = false;
                                    rouletteAgain = false;
                                    continue;
                                }

                                Tuple<bool, bool> bringBack = roulette.wantToContinue(lobbyAgain, rouletteAgain);
                                lobbyAgain = bringBack.Item1;
                                rouletteAgain = bringBack.Item2;
                            }
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(250);
                            Console.WriteLine("\n    There are 13 different groups of numbers for placing bets in the game. You cannot enter larger than 13 or lower than 1.\n");
                            rouletteAgain = true;
                        }
                    }
                } while (rouletteAgain);

                do
                {
                    if (mainGameDecision == 3)
                    {
                        if (40 > General.credit)
                        {
                            Console.Clear();
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                                           You must have $40 to run the slot machine.                         \n");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                    You left the slot machine. While you are walking towards the center of UMUT BET CENTER,   \n");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("                               you notice that the sounds coming from the slot machine decrease.              \n");

                            lobbyAgain = true;
                            slotGameAgain = false;
                        }
                        else
                        {
                            float beforeYouPlay = General.credit;

                            float AskBetSlot = slot.askBetSlot();

                            Tuple<int, int, int> bringback1 = slot.spin(AskBetSlot);
                            int firstColumn = bringback1.Item1;
                            int secondColumn = bringback1.Item2;
                            int thirdColumn = bringback1.Item3;

                            slot.showTheSpinResult(firstColumn, secondColumn, thirdColumn);
                            slot.win(firstColumn, secondColumn, thirdColumn, AskBetSlot);

                            if (General.credit > beforeYouPlay)
                            {
                                Console.WriteLine($"                                         Your earnings from this round is {General.credit - beforeYouPlay} dollars.                         ");
                                System.Threading.Thread.Sleep(500);
                            }
                            else if (General.credit < beforeYouPlay)
                            {
                                Console.WriteLine($"                                            Your loss on this round is {beforeYouPlay - General.credit} dollars.                            ");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("                                            You neither lost nor won on this round.                           ");
                                System.Threading.Thread.Sleep(500);
                            }

                            if (General.credit == 0)
                            {
                                Console.Clear();
                                System.Threading.Thread.Sleep(500);
                                Console.WriteLine("                   You were fired from Umut Bet Center for not having money to bet. Security accompanied you. \n");
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
                                Console.WriteLine("                                     |___|    |__________________________________|    |___|                   ");
                                lobbyAgain = false;
                                slotGameAgain = false;
                                continue;
                            }

                            Tuple<bool, bool> bringBack2 = slot.wantToContinue(lobbyAgain, slotGameAgain);
                            lobbyAgain = bringBack2.Item1;
                            slotGameAgain = bringBack2.Item2;
                        }
                    }
                } while (slotGameAgain);

                if (mainGameDecision == 4)
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("\n                                    Thank you for choosing Umut Bet Center, see you again...                  ");
                    lobbyAgain = false;
                }

            } while (lobbyAgain);
        }
    }
}