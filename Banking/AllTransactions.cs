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
    public partial class AllTransactions : Form
    {
        private BankingContext context = new BankingContext();
        private Wallet? wallet;
        public AllTransactions(int walletId)
        {
            this.wallet = context.Wallets.FirstOrDefault(w => w.Id == walletId);
            if (this.wallet == null)
            {
                MessageBox.Show("Wallet not found!");
                DialogResult = DialogResult.Cancel;
                return;
            }

            InitializeComponent();
            List<Income> incomes = context.Incomes.Where(i => i.WalletId == wallet.Id).ToList();
            List<Expense> expenses = context.Expenses.Where(i => i.WalletId == wallet.Id).ToList();
            List<ITransactions> transactions = incomes.Cast<ITransactions>().Concat(expenses.Cast<ITransactions>()).OrderByDescending(t => t.CreatedAt).ToList();

            dataGridView1.DataSource = transactions;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            List<ITransactions> transactions = new List<ITransactions>();
            
            DateTime d = start.Date;
            do
            {
                List<Income> incomes = context.Incomes.Where(i => i.CreatedAt >= d && i.CreatedAt <= d.AddDays(1) && i.WalletId == wallet.Id).ToList();
                List<Expense> expenses = context.Expenses.Where(i => i.CreatedAt >= d && i.CreatedAt <= d.AddDays(1) && i.WalletId == wallet.Id).ToList();
                transactions.AddRange(incomes.Cast<ITransactions>().Concat(expenses.Cast<ITransactions>()).ToList());
                d = d.AddDays(1);

            } while (d < end);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transactions.OrderByDescending(t => t.CreatedAt).ToList();
        }
    }
}
