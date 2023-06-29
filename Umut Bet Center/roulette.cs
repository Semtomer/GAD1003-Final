
namespace FinalProject
{
    public class roulette
    {
        public static Random rand = new Random();
        public static int[] Option1 = new int[18] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
        public static int[] Option2 = new int[18] { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        public static int[] Option3 = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public static int[] Option4 = new int[12] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        public static int[] Option5 = new int[12] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        public static int[] Option6 = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public static int[] Option7 = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        public static int[] Option8 = new int[1] { 0 };
        public static int[] Option9 = new int[18] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
        public static int[] Option10 = new int[18] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };
        public static int[] Option11 = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
        public static int[] Option12 = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public static int[] Option13 = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

        public static int choiceDecision()
        {
            bool again = false;
            do
            {
                try
                {
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("       ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo ");
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.Write("       o       o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("3");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   6   o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("9");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("12");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   15  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("18");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("21");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   24  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("27");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("30");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   33  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("36");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("  o   First Row   o");
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.WriteLine("       o       ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.Write("       o");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("   0");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   2   o");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   5");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   8   o   11  o");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   14");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   17  o   20  o");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   23");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   26  o   29  o");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("   32");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("  o   35  o  Second Row   o");
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.WriteLine("       o       ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.Write("       o       o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("1");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   4   o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("7");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("   o   10  o   13  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("16");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("19");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   22  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("25");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("  o   28  o   31  o   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("34");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("  o   Third Row   o");
                    Console.WriteLine("       o       o       o       o       o       o       o       o       o       o       o       o       o       o               o ");
                    Console.WriteLine("       ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("               o                               o                               o                               o                   ");
                    Console.WriteLine("               o      The numbers 1 to 12      o      The numbers 13 to 24     o      The numbers 25 to 36     o                   ");
                    Console.WriteLine("               o                               o                               o                               o                   ");
                    Console.WriteLine("               ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo                   ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("               o               o               o               o               o               o               o                   ");
                    Console.Write("               o      1-18     o      EVEN     o     BLACK     o      ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("RED");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("      o      ODD      o     19-36     o                   ");
                    Console.WriteLine("               o               o               o               o               o               o               o                   ");
                    Console.WriteLine("               ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo                   ");

                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                      The numbers 1 to 18   --> 2 odds  --> for press 1                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      The numbers 19 to 36  --> 2 odds  --> for press 2                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      The numbers 1 to 12   --> 3 odds  --> for press 3                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      The numbers 13 to 24  --> 3 odds  --> for press 4                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      The numbers 25 to 36  --> 3 odds  --> for press 5                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Red numbers           --> 2 odds  --> for press 6                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Black numbers         --> 2 odds  --> for press 7                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Green number ( 0 )    --> 37 odds --> for press 8                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Odd numbers           --> 2 odds  --> for press 9                       ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Even numbers          --> 2 odds  --> for press 10                      ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      First row numbers     --> 3 odds  --> for press 11                      ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Second row numbers    --> 3 odds  --> for press 12                      ");
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("                                      Third row numbers     --> 3 odds  --> for press 13                      \n");

                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                              Press the specified number of the group of numbers you want to bet.             \n");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("                                       If you want to leave Roulette table, press 14... ");

                    int choiceDecision = Convert.ToInt32(Console.ReadLine());

                    if (choiceDecision == 1)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                            You made your choice to the numbers 1 to 18, your devil be plentiful :)           \n");
                        return 1;
                    }
                    else if (choiceDecision == 2)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                            You made your choice to the numbers 19 to 36, your devil be plentiful :)          \n");
                        return 2;
                    }
                    else if (choiceDecision == 3)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                            You made your choice to the numbers 1 to 12, your devil be plentiful :)           \n");
                        return 3;
                    }
                    else if (choiceDecision == 4)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                            You made your choice to the numbers 13 to 24, your devil be plentiful :)          \n");
                        return 4;
                    }
                    else if (choiceDecision == 5)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                            You made your choice to the numbers 25 to 36, your devil be plentiful :)          \n");
                        return 5;
                    }
                    else if (choiceDecision == 6)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                              You made your choice to the Red numbers, your devil be plentiful :)             \n");
                        return 6;
                    }
                    else if (choiceDecision == 7)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                             You made your choice to the Black numbers, your devil be plentiful :)            \n");
                        return 7;
                    }
                    else if (choiceDecision == 8)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                           You made your choice to the Green number ( 0 ), your devil be plentiful :)         \n");
                        return 8;
                    }
                    else if (choiceDecision == 9)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                              You made your choice to the Odd numbers, your devil be plentiful :)             \n");
                        return 9;
                    }
                    else if (choiceDecision == 10)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                              You made your choice to the Even numbers, your devil be plentiful :)            \n");
                        return 10;
                    }
                    else if (choiceDecision == 11)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                          You made your choice to the First column numbers, your devil be plentiful :)        \n");
                        return 11;
                    }
                    else if (choiceDecision == 12)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                         You made your choice to the Second column numbers, your devil be plentiful :)        \n");
                        return 12;
                    }
                    else if (choiceDecision == 13)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                          You made your choice to the Third column numbers, your devil be plentiful :)        \n");
                        return 13;
                    }
                    else if (choiceDecision == 14)
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("                     You got up from the roulette table and walked towards the center of UMUT BET CENTER.     \n");
                        return 14;
                    }
                    else
                    {
                        Console.Clear();
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("                                  Please press in one of the numbers between 0 and 15 numbers.                \n");
                        again = true;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(0);
                    Console.WriteLine("                   You entered the invalid input. Please press in one of the numbers between 0 and 15 numbers.\n");
                    again = true;
                }
            } while (again);

            return 0;
        }
        public static void showTheChoices1(int choiceDecision1)
        {
            if (choiceDecision1 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                            In your first choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision1 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                            In your first choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision1 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                            In your first choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision1 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                            In your first choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision1 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                            In your first choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision1 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                              In your first choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision1 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                             In your first choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision1 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                           In your first choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision1 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                              In your first choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision1 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                              In your first choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision1 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                           In your first choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision1 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                           In your first choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision1 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("                           In your first choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices2(int choiceDecision2)
        {
            if (choiceDecision2 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your second choice, you have made your choice to the numbers 1 to 18.             \n");
            }
            else if (choiceDecision2 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your second choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision2 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your second choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision2 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your second choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision2 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your second choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision2 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your second choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision2 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your second choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision2 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your second choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision2 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your second choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision2 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your second choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision2 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your second choice, you have made your choice to the First row numbers.            \n");
            }
            else if (choiceDecision2 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your second choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision2 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your second choice, you have made your choice to the Third row numbers.            \n");
            }
        }
        public static void showTheChoices3(int choiceDecision3)
        {
            if (choiceDecision3 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your third choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision3 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your third choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision3 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your third choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision3 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your third choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision3 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your third choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision3 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your third choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision3 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your third choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision3 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your third choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision3 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your third choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision3 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your third choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision3 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your third choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision3 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your third choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision3 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your third choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices4(int choiceDecision4)
        {
            if (choiceDecision4 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fourth choice, you have made your choice to the numbers 1 to 18.             \n");
            }
            else if (choiceDecision4 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fourth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision4 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fourth choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision4 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fourth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision4 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fourth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision4 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your fourth choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision4 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your fourth choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision4 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your fourth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision4 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your fourth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision4 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your fourth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision4 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fourth choice, you have made your choice to the First row numbers.            \n");
            }
            else if (choiceDecision4 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your fourth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision4 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fourth choice, you have made your choice to the Third row numbers.            \n");
            }
        }
        public static void showTheChoices5(int choiceDecision5)
        {
            if (choiceDecision5 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fifth choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision5 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fifth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision5 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fifth choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision5 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fifth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision5 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your fifth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision5 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your fifth choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision5 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your fifth choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision5 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fifth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision5 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your fifth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision5 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your fifth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision5 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fifth choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision5 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fifth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision5 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your fifth choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices6(int choiceDecision6)
        {
            if (choiceDecision6 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your sixth choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision6 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your sixth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision6 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your sixth choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision6 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your sixth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision6 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your sixth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision6 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your sixth choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision6 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your sixth choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision6 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your sixth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision6 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your sixth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision6 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your sixth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision6 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your sixth choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision6 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your sixth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision6 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your sixth choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices7(int choiceDecision7)
        {
            if (choiceDecision7 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your seventh choice, you have made your choice to the numbers 1 to 18.             \n");
            }
            else if (choiceDecision7 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your seventh choice, you have made your choice to the numbers 19 to 36.            \n");
            }
            else if (choiceDecision7 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your seventh choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision7 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your seventh choice, you have made your choice to the numbers 13 to 24.            \n");
            }
            else if (choiceDecision7 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your seventh choice, you have made your choice to the numbers 25 to 36.            \n");
            }
            else if (choiceDecision7 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your seventh choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision7 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your seventh choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision7 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your seventh choice, you have made your choice to the Green ( 0 ) number.           \n");
            }
            else if (choiceDecision7 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your seventh choice, you have made your choice to the Odd numbers.               \n");
            }
            else if (choiceDecision7 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your seventh choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision7 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your seventh choice, you have made your choice to the First row numbers.            \n");
            }
            else if (choiceDecision7 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your seventh choice, you have made your choice to the Second row numbers.           \n");
            }
            else if (choiceDecision7 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your seventh choice, you have made your choice to the Third row numbers.            \n");
            }
        }
        public static void showTheChoices8(int choiceDecision8)
        {
            if (choiceDecision8 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your eighth choice, you have made your choice to the numbers 1 to 18.             \n");
            }
            else if (choiceDecision8 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eighth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision8 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your eighth choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision8 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eighth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision8 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eighth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision8 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your eighth choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision8 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your eighth choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision8 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eighth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision8 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your eighth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision8 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your eighth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision8 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eighth choice, you have made your choice to the First row numbers.            \n");
            }
            else if (choiceDecision8 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eighth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision8 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eighth choice, you have made your choice to the Third row numbers.            \n");
            }
        }
        public static void showTheChoices9(int choiceDecision9)
        {
            if (choiceDecision9 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your ninth choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision9 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your ninth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision9 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your ninth choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision9 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your ninth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision9 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your ninth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision9 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your ninth choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision9 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your ninth choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision9 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your ninth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision9 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your ninth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision9 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your ninth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision9 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your ninth choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision9 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your ninth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision9 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your ninth choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices10(int choiceDecision10)
        {
            if (choiceDecision10 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your tenth choice, you have made your choice to the numbers 1 to 18.              \n");
            }
            else if (choiceDecision10 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your tenth choice, you have made your choice to the numbers 19 to 36.             \n");
            }
            else if (choiceDecision10 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your tenth choice, you have made your choice to the numbers 1 to 12.              \n");
            }
            else if (choiceDecision10 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your tenth choice, you have made your choice to the numbers 13 to 24.             \n");
            }
            else if (choiceDecision10 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your tenth choice, you have made your choice to the numbers 25 to 36.             \n");
            }
            else if (choiceDecision10 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your tenth choice, you have made your choice to the Red numbers.                \n");
            }
            else if (choiceDecision10 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your tenth choice, you have made your choice to the Black numbers.               \n");
            }
            else if (choiceDecision10 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your tenth choice, you have made your choice to the Green ( 0 ) number.            \n");
            }
            else if (choiceDecision10 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your tenth choice, you have made your choice to the Odd numbers.                \n");
            }
            else if (choiceDecision10 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                              In your tenth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision10 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your tenth choice, you have made your choice to the First row numbers.             \n");
            }
            else if (choiceDecision10 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your tenth choice, you have made your choice to the Second row numbers.            \n");
            }
            else if (choiceDecision10 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your tenth choice, you have made your choice to the Third row numbers.             \n");
            }
        }
        public static void showTheChoices11(int choiceDecision11)
        {
            if (choiceDecision11 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eleventh choice, you have made your choice to the numbers 1 to 18.            \n");
            }
            else if (choiceDecision11 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the numbers 19 to 36.            \n");
            }
            else if (choiceDecision11 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision11 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the numbers 13 to 24.            \n");
            }
            else if (choiceDecision11 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the numbers 25 to 36.            \n");
            }
            else if (choiceDecision11 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your eleventh choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision11 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your eleventh choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision11 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your eleventh choice, you have made your choice to the Green ( 0 ) number.           \n");
            }
            else if (choiceDecision11 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your eleventh choice, you have made your choice to the Odd numbers.               \n");
            }
            else if (choiceDecision11 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your eleventh choice, you have made your choice to the Even numbers.              \n");
            }
            else if (choiceDecision11 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the First row numbers.           \n");
            }
            else if (choiceDecision11 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your eleventh choice, you have made your choice to the Second row numbers.           \n");
            }
            else if (choiceDecision11 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your eleventh choice, you have made your choice to the Third row numbers.           \n");
            }
        }
        public static void showTheChoices12(int choiceDecision12)
        {
            if (choiceDecision12 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your twelfth choice, you have made your choice to the numbers 1 to 18.             \n");
            }
            else if (choiceDecision12 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your twelfth choice, you have made your choice to the numbers 19 to 36.            \n");
            }
            else if (choiceDecision12 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your twelfth choice, you have made your choice to the numbers 1 to 12.             \n");
            }
            else if (choiceDecision12 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your twelfth choice, you have made your choice to the numbers 13 to 24.            \n");
            }
            else if (choiceDecision12 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your twelfth choice, you have made your choice to the numbers 25 to 36.            \n");
            }
            else if (choiceDecision12 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your twelfth choice, you have made your choice to the Red numbers.               \n");
            }
            else if (choiceDecision12 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your twelfth choice, you have made your choice to the Black numbers.              \n");
            }
            else if (choiceDecision12 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your twelfth choice, you have made your choice to the Green ( 0 ) number.           \n");
            }
            else if (choiceDecision12 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                             In your twelfth choice, you have made your choice to the Odd numbers.               \n");
            }
            else if (choiceDecision12 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                            In your twelfth choice, you have made your choice to the Even numbers.               \n");
            }
            else if (choiceDecision12 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your twelfth choice, you have made your choice to the First row numbers.            \n");
            }
            else if (choiceDecision12 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your twelfth choice, you have made your choice to the Second row numbers.           \n");
            }
            else if (choiceDecision12 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your twelfth choice, you have made your choice to the Third row numbers.            \n");
            }
        }
        public static void showTheChoices13(int choiceDecision13)
        {
            if (choiceDecision13 == 1)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your thirteenth choice, you have made your choice to the numbers 1 to 18.           \n");
            }
            else if (choiceDecision13 == 2)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your thirteenth choice, you have made your choice to the numbers 19 to 36.           \n");
            }
            else if (choiceDecision13 == 3)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your thirteenth choice, you have made your choice to the numbers 1 to 12.           \n");
            }
            else if (choiceDecision13 == 4)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your thirteenth choice, you have made your choice to the numbers 13 to 24.           \n");
            }
            else if (choiceDecision13 == 5)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your thirteenth choice, you have made your choice to the numbers 25 to 36.           \n");
            }
            else if (choiceDecision13 == 6)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your thirteenth choice, you have made your choice to the Red numbers.              \n");
            }
            else if (choiceDecision13 == 7)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                          In your thirteenth choice, you have made your choice to the Black numbers.             \n");
            }
            else if (choiceDecision13 == 8)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                        In your thirteenth choice, you have made your choice to the Green ( 0 ) number.          \n");
            }
            else if (choiceDecision13 == 9)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your thirteenth choice, you have made your choice to the Odd numbers.              \n");
            }
            else if (choiceDecision13 == 10)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                           In your thirteenth choice, you have made your choice to the Even numbers.             \n");
            }
            else if (choiceDecision13 == 11)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your thirteenth choice, you have made your choice to the First row numbers.          \n");
            }
            else if (choiceDecision13 == 12)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                        In your thirteenth choice, you have made your choice to the Second row numbers.          \n");
            }
            else if (choiceDecision13 == 13)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n                         In your thirteenth choice, you have made your choice to the Third row numbers.          \n");
            }
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, float ChoiceDecision2, float AskBet2)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8, int ChoiceDecision9, float AskBet9)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision9)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8, int ChoiceDecision9, float AskBet9, int ChoiceDecision10, float AskBet10)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision9)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision10)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8, int ChoiceDecision9, float AskBet9, int ChoiceDecision10, float AskBet10, int ChoiceDecision11, float AskBet11)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision9)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision10)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision11)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8, int ChoiceDecision9, float AskBet9, int ChoiceDecision10, float AskBet10, int ChoiceDecision11, float AskBet11, int ChoiceDecision12, float AskBet12)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision9)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision10)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision11)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision12)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }
        public static void rouletteResult(int ChoiceDecision1, float AskBet1, int ChoiceDecision2, float AskBet2, int ChoiceDecision3, float AskBet3, int ChoiceDecision4, float AskBet4, int ChoiceDecision5, float AskBet5, int ChoiceDecision6, float AskBet6, int ChoiceDecision7, float AskBet7, int ChoiceDecision8, float AskBet8, int ChoiceDecision9, float AskBet9, int ChoiceDecision10, float AskBet10, int ChoiceDecision11, float AskBet11, int ChoiceDecision12, float AskBet12, int ChoiceDecision13, float AskBet13)
        {
            Console.Clear();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                              The employee puts the ball on roulette and the ball starts spinning.            \n");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("                                   Soon the ball will stop and the number will be announced.                  \n");

            int[] participations = new int[37] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int pick = rand.Next(0, participations.Length);

            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"                                     The ball stopped and the number below the ball is {pick}.\n");

            switch (ChoiceDecision1)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet1 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision2)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet2 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision3)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet3 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision4)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet4 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision5)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet5 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision6)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet6 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision7)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet7 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision8)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet8 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision9)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet9 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision10)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet10 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision11)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet11 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision12)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet12 * 3;
                        }
                    }
                    break;

            }
            switch (ChoiceDecision13)
            {
                case 1:
                    foreach (int isThere in Option1)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 2:
                    foreach (int isThere in Option2)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 3:
                    foreach (int isThere in Option3)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;
                case 4:
                    foreach (int isThere in Option4)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;
                case 5:
                    foreach (int isThere in Option5)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;
                case 6:
                    foreach (int isThere in Option6)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 7:
                    foreach (int isThere in Option7)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 8:
                    foreach (int isThere in Option8)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 37;
                        }
                    }
                    break;
                case 9:
                    foreach (int isThere in Option9)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 10:
                    foreach (int isThere in Option10)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 2;
                        }
                    }
                    break;
                case 11:
                    foreach (int isThere in Option11)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;
                case 12:
                    foreach (int isThere in Option12)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;
                case 13:
                    foreach (int isThere in Option13)
                    {
                        if (pick == isThere)
                        {
                            General.credit += AskBet13 * 3;
                        }
                    }
                    break;

            }

            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"                                                 You have {General.credit} dollars currently.                        \n");
            System.Threading.Thread.Sleep(1500);
        }

        public static Tuple<bool, bool> wantToContinue(bool lobbyAgain, bool rouletteAgain)
        {
            bool continueAgain = false;

            do
            {
                System.Threading.Thread.Sleep(500);
                Console.Write("\n                                       Do you want to continue playing the roulette?(Y/N) ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "y" || answer == "yes")
                {
                    Console.Clear();
                    lobbyAgain = false;
                    rouletteAgain = true;
                    continueAgain = false;
                }
                else if (answer == "n" || answer == "no")
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("                     You got up from the roulette table and walked towards the center of UMUT BET CENTER.     \n");
                    lobbyAgain = true;
                    rouletteAgain = false;
                    continueAgain = false;
                }
                else
                {
                    System.Threading.Thread.Sleep(250);
                    Console.WriteLine("\n                                                Please just type 'Yes' or 'No'.                               ");
                    continueAgain = true;
                }
            } while (continueAgain);

            return Tuple.Create(lobbyAgain, rouletteAgain);
        }
    }
}
