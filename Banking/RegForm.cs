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
    public partial class RegForm : Form
    {
        private BankingContext context;
        public RegForm()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            if(Nametxt.Text != null && passeord2txt.Text != null && passwordtxt.Text != null && Nametxt.Text != null && Emailtxt.Text != null)
            {
                context = new BankingContext();
                if (passwordtxt.Text == passeord2txt.Text && context.Users.FirstOrDefault(u => u.Name == Nametxt.Text) == null && context.Users.FirstOrDefault(u => u.Email == Emailtxt.Text) == null)
                {
                    User user = new User();
                    user.Name = Nametxt.Text;
                    user.Email = Emailtxt.Text;
                    user.Password = passeord2txt.Text;
                    context.Users.Add(user);
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                    Main main = new Main(user);
                    main.Show();

                    this.Hide(); // або this.Close();


                }
                else
                {
                    MessageBox.Show("This user name or email is using");
                }
            }
            else
            {
                MessageBox.Show("Please enter all rows");
            }
           
            

        }
    }
}
