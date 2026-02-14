namespace ATMApp.Services
{
   public static class BankingServices
{
    public static double GetBalance(double balance)
    {
        
       return balance;
    }
    public static void Deposit(ref double balance, double amount, out bool isSuccessful)
    {
        if(amount < 1){
            isSuccessful = false;
            return;
        }
        balance += amount;
        isSuccessful = true;
    }
    public static void Withdraw(
            ref double balance,
            double amount,
            out bool isSuccessful)
    {
        if(amount > balance){
          isSuccessful = false; 
          Console.WriteLine("Withdrawal failed. Insufficient balance.");
          return;
        } 
        if(amount < 1){
           isSuccessful = false; 
          Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
          return;
        }
             balance -= amount;
             isSuccessful = true;
    }
    public static void PrintMiniStatement(
            double balance,
            double lastTransaction)

    {
        Console.WriteLine("--- Mini Statement ---");
        Console.WriteLine("Current Balance: " + balance);
        Console.WriteLine("Last Transaction Amount: " + lastTransaction);
    }
    
}
}
