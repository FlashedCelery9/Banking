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
    public partial class CreateWallet : Form
    {
        private User user;
        private BankingContext context = new BankingContext();
        public CreateWallet(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CreateWallet_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = context.Currencies.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && walletsNameTxt.Text.Length > 4 )
            {

                Wallet wallet = new Wallet
                {
                    UserId = user.Id,
                    CurrencyId = (int)comboBox1.SelectedValue,
                    Balance = 0,
                    Name = walletsNameTxt.Text
                };

                context.Wallets.Add(wallet);
                context.SaveChanges();


                MessageBox.Show("Гаманець створено");
                DialogResult = DialogResult.OK;
                
            }
            //else if(comboBox1.SelectedIndex != -1 && walletsNameTxt.Text.Length > 4 && user.Wallets.Count > 0)
            //{
            //    DialogResult result = MessageBox.Show(
            //        "Відкриття додаткового гаманця платна процедура. Підтвердити?",
            //        "Підтвердження",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning
            //    );
            //    if(result == DialogResult.OK)
            //    {
            //        Wallet wallet = new Wallet
            //        {
            //            UserId = user.Id,
            //            CurrencyId = (int)comboBox1.SelectedValue,
            //            Balance = 0,
                        
            //        };

            //        context.Wallets.Add(wallet);
            //        context.SaveChanges();


            //        MessageBox.Show("Гаманець створено");
            //        DialogResult = DialogResult.OK;
            //    }
            //}
            else
            {
                MessageBox.Show("Виникла непередбачуванна помилка");

            }
        }
    }
}
