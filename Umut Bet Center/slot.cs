
namespace FinalProject
{
    public class slot
    {
        public static Random rand = new Random();
        public static float askBetSlot()
        {
            bool again = false;
            float bet;

            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                              You have {General.credit} dollars to place a bet.                         \n");
            Console.WriteLine("                                                You can bet with at least $ 40.                               \n");

            do
            {
                if (General.credit == 0)
                {
                    bet = 0;
                    continue;
                }

                System.Threading.Thread.Sleep(500);
                Console.Write("                                        How much do you want to bet on this slot game ? ");

                while (!float.TryParse(Console.ReadLine(), out bet))
                {
                    System.Threading.Thread.Sleep(250);
                    Console.Write("\n                           You entered the invalid input. Please press the numbers to bet on this odd. ");
                }

                if (bet > General.credit)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                              You tried to make more money than you have, don't do it, we'll burn.            \n");
                    again = true;
                    continue;
                }
                else if (bet < 40)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                                  You can't fool the system :(                                \n");
                    again = true;
                    continue;
                }
                again = false;
            } while (again);

            General.credit -= bet;
            return bet;
        }
        public static Tuple<int, int, int> spin(float AskBetSlot)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                           You pulled the handle of the slot machine.                         \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                         The machine worked. After 5 seconds, the results will be showed on the screen.       \n");

            int[] moneyList = new int[6] { 1, 5, 10, 20, 50, 100 };
            int column1 = rand.Next(0, moneyList.Length);
            int column2 = rand.Next(0, moneyList.Length);
            int column3 = rand.Next(0, moneyList.Length);

            int firstColumn = moneyList[column1];
            int secondColumn = moneyList[column2];
            int thirdColumn = moneyList[column3];

            return Tuple.Create(firstColumn, secondColumn, thirdColumn);

        }
        public static void showTheSpinResult(int firstColumn, int secondColumn, int thirdColumn)
        {
            if (firstColumn == 1)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $1     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (firstColumn == 5)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $5     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (firstColumn == 10)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $10     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (firstColumn == 20)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $20     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (firstColumn == 50)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $50     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (firstColumn == 100)
            {
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("                                                         First Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $100    |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }

            if (secondColumn == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $1     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (secondColumn == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $5     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (secondColumn == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $10     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (secondColumn == 20)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $20     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (secondColumn == 50)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $50     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (secondColumn == 100)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Second Column                                        ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $100    |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }

            if (thirdColumn == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $1     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (thirdColumn == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |      $5     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (thirdColumn == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $10     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (thirdColumn == 20)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $20     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (thirdColumn == 50)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $50     |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
            else if (thirdColumn == 100)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                                                         Third Column                                         ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                      ___________________                                     ");
                Console.WriteLine("                                                     |   _____________   |                                    ");
                Console.WriteLine("                                                     |  |             |  |                                    ");
                System.Threading.Thread.Sleep(250);
                Console.WriteLine("                                                     |  |     $100    |  |                                    ");
                Console.WriteLine("                                                     |  |_____________|  |                                    ");
                Console.WriteLine("                                                     |___________________|                                    \n");
            }
        }
        public static void win(int firstColumn, int secondColumn, int thirdColumn, float AskBetSlot)
        {

            if (firstColumn == secondColumn && firstColumn == thirdColumn)
            {
                General.credit += AskBetSlot * 3;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (firstColumn == secondColumn || firstColumn == thirdColumn)
            {
                General.credit += AskBetSlot * 2;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else if (secondColumn == thirdColumn)
            {
                General.credit += AskBetSlot * 2;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
                System.Threading.Thread.Sleep(1000);
            }
        }
        public static Tuple<bool, bool> wantToContinue(bool lobbyAgain, bool slotGameAgain)
        {
            bool continueAgain = false;

            do
            {
                System.Threading.Thread.Sleep(500);
                Console.Write("\n                                     Do you want to continue playing the slot machine?(Y/N) ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y" || answer == "yes")
                {
                    Console.Clear();
                    lobbyAgain = false;
                    slotGameAgain = true;
                    continueAgain = false;
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                    You left the slot machine. While you are walking towards the center of UMUT BET CENTER,   ");
                    Console.WriteLine("                               you notice that the sounds coming from the slot machine decrease.              \n");
                    lobbyAgain = true;
                    slotGameAgain = false;
                    continueAgain = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                                Please just type 'Yes' or 'No'.                               ");
                    continueAgain = true;
                }
            } while (continueAgain);

            return Tuple.Create(lobbyAgain, slotGameAgain);
        }


    }
}
