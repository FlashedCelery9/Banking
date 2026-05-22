using Banking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Banking
{
    public partial class Transaction : Form
    {
        private Wallet wallet;
        private BankingContext context;
        private string[] categories_income = { "Salary", "IncomeFromPersone" };
        private string[] categories_expense = { "Foods", "Quarts", "PayToPersone", "Games", "Cafe" };

        public Transaction(int walletId)
        {
            context = new BankingContext();
            this.wallet = context.Wallets.FirstOrDefault(w=> w.Id == walletId);
            InitializeComponent();
            if (this.wallet == null)
            {
                MessageBox.Show("Wallet not found");
                Close();
                return;
            }
            label4.Text = $"Balance: {wallet.Balance} {wallet.CurrencyName}";
                IncomeCategory.DataSource = categories_income;
                ExpenseCategory.DataSource = categories_expense;
            
            


        }

        private void createIncomebtn_Click(object sender, EventArgs e)
        {
            if (IncomeCategory.Text.Length > 4 && IncomeAmount.Text.Length != 0 )
            {

                if (!decimal.TryParse(IncomeAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }
                if (amount < 1000)
                {
                    Income income = new Income();
                    income.WalletId = this.wallet.Id;
                    income.Amount = amount;
                    income.Category = IncomeCategory.Text;
                    income.Person = IncomeCategory.Text;
                    income.Remainder = this.wallet.Balance + amount;
                    context.Incomes.Add(income);
                    this.wallet.Balance += amount;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Будь ласка заповніть всі поля");

            }
        }

        private void createExpensebtn_Click(object sender, EventArgs e)
        {
            if (ExpenseCategory.Text.Length > 4 && ExpenseAmount.Text.Length != 0)
            {
                if (!decimal.TryParse(ExpenseAmount.Text, out decimal amount))
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }


                if (ExpenseCategory.Text == "PayToPersone" && textBox1.Text.Length != 0)
                {
                    User? person = context.Users
                        .FirstOrDefault(u => u.Email == textBox1.Text);

                    if (person == null)
                    {
                        MessageBox.Show("User not found");
                        return;
                    }

                    var senderWallet = context.Wallets
                        .Include(w => w.User)
                        .FirstOrDefault(w => w.Id == wallet.Id);
                    if (senderWallet?.User?.Email == null)
                    {
                        MessageBox.Show("User data is missing");
                        return;
                    }

                    if (textBox1.Text == senderWallet.User.Email)
                    {
                        MessageBox.Show("This is your wallet or email.");
                        return;
                    }
                  
                    

                        
                    Wallet? receiverWallet = context.Wallets
                        .FirstOrDefault(w => w.UserId == person.Id);

                    if (receiverWallet == null || senderWallet.CurrencyName != receiverWallet.CurrencyName)
                    {
                        MessageBox.Show("Wallet not found");
                        return;
                    }

                    if (senderWallet == null || senderWallet.Balance < amount)
                    {
                        MessageBox.Show("Not enough money");
                        DialogResult = DialogResult.Cancel;
                        return;
                    }


                    Expense expense = new Expense()
                    {
                        WalletId = senderWallet.Id,
                        Category = "PayToPersone",
                        Amount = amount,
                        Person = receiverWallet.User.Name,
                        Remainder = senderWallet.Balance - amount
                     
                    };

                    context.Expenses.Add(expense);

                    senderWallet.Balance -= amount;

                    Income income = new Income()
                    {
                        WalletId = receiverWallet.Id,
                        Category = "IncomeFromPersone",
                        Amount = amount,
                        Person = senderWallet.User.Name,
                        Remainder = receiverWallet.Balance + amount

                    };

                    context.Incomes.Add(income);

                    receiverWallet.Balance += amount;
                    

                    context.SaveChanges();
                    context.Entry(receiverWallet).Reload();
                    context.Entry(senderWallet).Reload();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // звичайний витрата
                    Wallet? senderWallet = context.Wallets
                        .FirstOrDefault(w => w.Id == wallet.Id);

                    if (senderWallet == null || senderWallet.Balance < amount)
                    {
                        MessageBox.Show("Not enough money");
                        DialogResult = DialogResult.Cancel;
                        return;
                    }

                    Expense expense = new Expense()
                    {
                        WalletId = senderWallet.Id,
                        Category = ExpenseCategory.Text,
                        Amount = amount,
                        Person = ExpenseCategory.Text,
                        Remainder = senderWallet.Balance - amount

                    };

                    context.Expenses.Add(expense);

                    senderWallet.Balance -= amount;

                    context.SaveChanges();

                    DialogResult = DialogResult.OK;
                }
               
               
            }
            else
            {
                MessageBox.Show("Fill all fields");
            }
        
    
    



             
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
        }
    }
}
