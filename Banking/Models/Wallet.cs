using Banking.Models;
using System;
using System.Threading.Tasks.Sources;


public class Wallet
{
    public int Id { get; set; }
    public decimal Balance { get; set; } = 0;
    public string Name { get; set; }
    

    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;

    public int CurrencyId { get; set; }
    public virtual Currency Currency { get; set; } = null!; //Валюта

    public ICollection<Income> Incomes { get; set; } = new List<Income>(); //Надходження (Список)
    public ICollection<Expense> Expenses { get; set; } = new List<Expense>(); //Витрати (Список)

    public string CurrencyName
    {
        get
        {
            if (Currency != null)
            {
                // якщо є валюта, повертай її Name
                return Currency.Name;
            }
            else
            {
                // fallback за Id або дефолт
                if (CurrencyId == 1)
                    return "USD";
                else if (CurrencyId == 2)
                    return "EUR";
                else if (CurrencyId == 3)
                    return "UAH";
                else
                    return "Unknown";
            }
        }
    }
}
