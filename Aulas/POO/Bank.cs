namespace firstProject;

public class Bank
{
    public string Name { get; set; }
    public int AccountNumber { get; private set;}
    public double Balance { get; private set; }

    // construtor com parâmetros
    public Bank(string name, int account)
    {
        Name = name;
        AccountNumber = account;
    }

    public Bank(string name, int account, double initialBalance)
    {
        Name = name;
        AccountNumber = account;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        Balance = Balance - amount - 5.00;
    }

    public override string ToString()
    {
        return $"Conta {AccountNumber}, Titular: {Name}, Saldo: $ {Balance:F2}";
    }

}
