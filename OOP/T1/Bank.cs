public class BankAccount
{
    private string Owner;
    private string AccountNumber;
    private decimal Balance;
    private string AccountType;
    public BankAccount(string owner, string accnum, decimal balance, string acctype)
    {
        Owner = owner;
        AccountNumber = accnum;
        Balance = balance;
        AccountType = acctype;
    }
    public void Deposit(decimal count)
    {
        Balance += count;
        System.Console.WriteLine($"Your account has been credited with ${count}. Your new balance is ${Balance}.");
    }
    public void Withdraw(decimal count)
    {
        Balance -= count;
        System.Console.WriteLine($"An amount of ${count} has been deducted from your account. Your current balance is ${Balance}");
    }
    public void TransferTo(BankAccount target, decimal amount)
    {
        target.Balance += amount;
        Balance -= amount;
        System.Console.WriteLine($"Перевод: {amount} от {Owner} к {target.Owner}. Баланс: Али - {Balance}, Мунира - {target.Balance}. {Owner}: -{amount}. {target.Owner} +{amount}");
    }
}