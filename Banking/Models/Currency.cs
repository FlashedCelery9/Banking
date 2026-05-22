using System;

public class Currency
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = "none";
    public string Symbol { get; set; } = null!;

    public ICollection<Wallet> Wallets { get; set; } = new List<Wallet>(); //Колекція гаманців


}
