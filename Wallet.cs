using System;


public class Wallet
{
	public int id { get; set; }
    public decimal Balance { get; set; }

	public int UserId { get; set; }
	public virtual User _User { get; set; } != null;

	public int CurrencyId { get; set; }
	public virtual Currency { get; set; } 
  
}
