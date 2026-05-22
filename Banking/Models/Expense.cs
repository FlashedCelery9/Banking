using Banking.Models;
using System;

public class Expense : ITransactions
{ 
    public int Id { get; set; }
    public string Category { get; set; } = null!;
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; //Автоматично підтягує час транзакції
    public int WalletId { get; set; }
    public string _amount => $"-{Amount}";
    public decimal Remainder { get; set; }
    public string Person { get; set; } //Sender 


    public Wallet Wallet { get; set; } = null!;

}   
