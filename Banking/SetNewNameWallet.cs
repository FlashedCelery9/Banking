using Banking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Banking
{
    public partial class SetNewNameWallet : Form
    {
        public BankingContext context = new BankingContext();
        Wallet? wallet;
        public SetNewNameWallet(int walletId)
        {
            wallet = context.Wallets.FirstOrDefault(w => w.Id == walletId);
            if (wallet == null)
            {
                MessageBox.Show("Eror", "Eror", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                return;
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(wallet != null)
                wallet.Name = textBox1.Text;
            context.SaveChanges();
            DialogResult = DialogResult.OK;


        }
    }
}
