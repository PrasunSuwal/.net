using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; private set; }

    // Constructor
    public BankAccount(string accountNumber, string accountName, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        AccountName = accountName;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance is {Balance:C}.");
    }

    // Method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance for this withdrawal.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrew {amount:C}. New balance is {Balance:C}.");
    }

    // Method to display account details
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Name: {AccountName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Create a new bank account
        BankAccount account = new BankAccount("123456789", "John Doe", 1000);

        // Display account details
        account.DisplayAccountDetails();

        // Deposit money
        account.Deposit(500);

        // Withdraw money
        account.Withdraw(300);

        // Attempt to withdraw more than the balance
        account.Withdraw(1500);
    }
}
