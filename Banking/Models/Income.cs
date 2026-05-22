using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class Income : ITransactions
    { 
        public int Id { get; set; }
        public string? Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int WalletId { get; set; }
        public string _amount => $"+ {Amount}";
        public decimal Remainder { get; set; }
        public string Person { get; set; } //Sender 

        public virtual Wallet Wallet { get; set; } = null!;
    }
}
