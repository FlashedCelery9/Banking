using Banking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banking
{
    public partial class Main : Form
    {
        private User user;
        private Wallet wallet;
        private Wallet selectedwallet;

        public Main(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Username.Text = user.Name;
            UpdateWallets();
        }

        private void SelectWallet(object sender, EventArgs e)
        {
            if (walletscombobox.SelectedItem is Wallet selected)
            {
                wallet = selected;
                selectedwallet = selected;

                UpdateStats();
            }
        }

        private void createWalletbtn_Click(object sender, EventArgs e)
        {
            CreateWallet createWallet = new CreateWallet(user);
            if (createWallet.ShowDialog() == DialogResult.OK)
            {
                UpdateWallets();
            }
        }

        private void UpdateWallets()
        {
            using var context = new BankingContext();
            var wallets = context.Wallets
                .Where(w => w.UserId == user.Id)
                .ToList();

            walletscombobox.DataSource = wallets;
            walletscombobox.DisplayMember = "Name"; // або "Name", якщо поле додано
            walletscombobox.ValueMember = "Id";

            if (wallets.Any())
            {
                walletscombobox.SelectedIndex = 0;
                wallet = wallets[0];
                selectedwallet = wallets[0];
                UpdateStats();
            }
        }

        private void UpdateStats()
        {
            if (wallet == null) return;

            using var context = new BankingContext();
            wallet = context.Wallets
                .Include(w => w.Incomes)
                .Include(w => w.Expenses)
                .FirstOrDefault(w => w.Id == wallet.Id);

            if (wallet == null) return;

            balance.Text = wallet.Balance.ToString();
            type.Text = wallet.CurrencyName;
            income.Text = (wallet.Incomes?.Sum(i => i.Amount) ?? 0).ToString();
            expense.Text = (wallet.Expenses?.Sum(e => e.Amount) ?? 0).ToString();

            var transactions = wallet.Incomes.Cast<ITransactions>()
                .Concat(wallet.Expenses.Cast<ITransactions>())
                .OrderByDescending(t => t.CreatedAt)
                .Take(5)
                .ToList();

            IncomeDataGrid.DataSource = transactions;
            IncomeDataGrid.Columns["Id"].Visible = false;
            IncomeDataGrid.Columns["Amount"].Visible = false;
        }

        private void Transactionsbtn_Click(object sender, EventArgs e)
        {
            using var context = new BankingContext();
            var form = new Transaction(wallet.Id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateStats();
            }
        }

        private void Analyticsbtn_Click(object sender, EventArgs e)
        {
            var analytics = new Analytics(selectedwallet);
            analytics.ShowDialog();
            UpdateStats();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            var allTrans = new AllTransactions(wallet.Id);
            allTrans.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedwallet != null)
            {
                var warning = new SetNewNameWallet(wallet.Id);
                if (warning.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Гаманець змінено успішно!");
                    UpdateWallets();
                }
            }
            else
            {
                MessageBox.Show("Wallet not found!");

            }

        }

        private void label7_MouseEnter(object sender, EventArgs e) => label7.ForeColor = Color.AntiqueWhite;
        private void label7_MouseLeave(object sender, EventArgs e) => label7.ForeColor = Color.Black;
    }
}