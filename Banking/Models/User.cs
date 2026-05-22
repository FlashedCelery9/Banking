using System;

public class User
{
    public int Id { get; set; } 
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public ICollection<Wallet> Wallets { get; set; } = new List<Wallet>(); //Гаманці (колекція) 

}
