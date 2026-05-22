using Banking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Banking
{
    public partial class Auth : Form
    {
        private BankingContext context;
        private User user;
        public Auth()
        {
            
            InitializeComponent();
            context = new BankingContext();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (context.Users.FirstOrDefault(u => u.Email == Emailtxt.Text) != null)
            {
                if (context.Users.FirstOrDefault(u => u.Password == passwordtxt.Text) != null)
                {
                    user = context.Users.FirstOrDefault(u => u.Email == Emailtxt.Text);
                    if (user != null)
                    {
                        Main main = new Main(user);

                        main.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Невірний email або пароль");
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegForm form = new RegForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Hide();

            }

        }
    }
}
