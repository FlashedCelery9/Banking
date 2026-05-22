using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public interface ITransactions
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string _amount => $"{Amount}";
        public string Person { get; set; } //Reciver or Sender
        public decimal Remainder { get; set; }


    }
}
