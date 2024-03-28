using System;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInputs();
            Console.ReadKey();
        }

        private static void GetInputs()
        {
            PrintMessage("Enter Username: ");
            var user = Console.ReadLine();
            PrintMessage("Enter User Password: ");
            var password = Console.ReadLine();

            if (user != null && password != null)
            {
                if (password == "admin" && user == "behnam")
                {
                    PrintMessage("Welcome, sir!");
                    ClearConsole().Wait(); // Wait for ClearConsole to complete
                }
                else
                {
                    PrintMessage("Wrong username or password");
                }
            }
            PrintMessage("Thanks for your visit!");
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static async Task ClearConsole()
        {
            await Task.Delay(1000);
            Console.Clear();
            MainMenu();
        }

        private static void MainMenu()
        {
            int item;
            do
            {
                PrintMessage("****** Choose your panel: ******** ");
                PrintMessage("1* Account Setting");
                PrintMessage("2* Customer Setting");
                PrintMessage("3* Funds Transfer Setting: ");
                PrintMessage("4* Exit ");
                PrintMessage("Enter Your Panel: ");
                if (!int.TryParse(Console.ReadLine(), out item))
                {
                    PrintMessage("Invalid input. Please enter a number.");
                    continue;
                }
                SelectedMenu(item);
            } while (item != 4); // Exit loop when the user selects 4
        }

        private static void AccountMenu()
        {
            int item;
            do
            {
                PrintMessage("****** Choose your panel: ******** ");
                PrintMessage("0* Main Menu");
                PrintMessage("1* Account Setting");
                PrintMessage("2* Transfer Account");
                PrintMessage("3* Delete Account ");
                PrintMessage("4* Exit ");
                PrintMessage("Enter Your Choise: ");
                if (!int.TryParse(Console.ReadLine(), out item))
                {
                    PrintMessage("Invalid input. Please enter a number.");
                    continue;
                }
                SelectedMenu(item);
            } while (item != 4); // Exit loop when the user selects 4
        }

        private static void SelectedMenu(int menuNum)
        {
            switch (menuNum)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    AccountMenu();
                    break;
                case 2:
                    // Implement Customer Setting
                    break;
                case 3:
                    // Implement Funds Transfer Setting
                    break;
                case 4:
                    PrintMessage("Exiting program...");
                    break;
                default:
                    PrintMessage("Wrong number");
                    break;
            }
        }
    }
}
