using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class BankingContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=D:\\VS\\Banking\\Banking\\products.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Name = "User-1", Password = "123123", Email = "email1@gmail.com"},
                new User {Id = 2, Name = "User-2", Password = "23232323", Email = "email2@gmail.com" },
                new User {Id = 3, Name = "User-3", Password = "22002200", Email = "email3@gmail.com" },
                new User {Id = 4, Name = "User-4", Password = "123123", Email = "email4@gmail.com" });

          
            modelBuilder.Entity<Currency>().HasData(
                new Currency { Id = 1, Name = "UNITED_STATES_DOLLAR", Symbol = "$", Code="USD"},
                new Currency { Id = 2, Name = "EURO", Symbol = "€", Code="EUR"},
            new Currency { Id = 3, Name = "UKRAINIAN_H", Symbol = "₴", Code = "UAH" });




        }
    }
}
