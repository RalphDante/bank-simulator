// COMANDANTE, RALPH T.
// === Simple ATM System ===
using ATMApp.Services;

namespace ATMApp.View
{
    public static class BankingView
    {
  
        public static void Run()
        {
            double accountBalance = 1000.00;
            double lastTransaction = 0;
            int userInput = 0;
            while(userInput != 5){
                Console.WriteLine("Balance: " + accountBalance);
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Deposit Money");
                Console.WriteLine("3: Withdraw Money");
                Console.WriteLine("4: Print Mini Statement");
                Console.WriteLine("5: Exit");
                Console.WriteLine("Enter your choice: ");
                userInput = Int32.Parse(Console.ReadLine());
                switch(userInput){
                    case 1:
                        BankingServices.GetBalance(accountBalance);
                        break;
                        
                    case 2:
                        Console.WriteLine("Input amount to deposit: ");
                        bool isSuccessful1;
                        double amount1 = Int32.Parse(Console.ReadLine());
                         lastTransaction = accountBalance;
                        BankingServices.Deposit(ref accountBalance, amount1, out isSuccessful1);
                        Console.WriteLine((isSuccessful1 ? "Deposit successful." : "Invalid deposit amount. Please enter a positive value."));
                       
                        break;
                    case 3:
                        Console.WriteLine("Input amount to withdraw: ");
                        double amount2 = Int32.Parse(Console.ReadLine());
                        bool isSuccessful2;
                          lastTransaction = accountBalance;
                        BankingServices.Withdraw(ref accountBalance, amount2, out isSuccessful2);
                        Console.WriteLine((isSuccessful2 ? "Withdraw successful." : ""));
                        break;
                    case 4:
                        BankingServices.PrintMiniStatement(accountBalance, lastTransaction);
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                        return;
                    default:
                        Console.WriteLine("Invalid option selected. Please try again.");
                        continue;
                }
            }
          
        }
    }
}
