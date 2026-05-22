using Banking.Models;
using FastReport.DataVisualization.Charting;
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
    public partial class Analytics : Form
    {
        private BankingContext context;
        private Wallet wallet;
        public Analytics(Wallet wallet)
        {
            context = new BankingContext();
            this.wallet = wallet;
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            chart1.ChartAreas.Add(new ChartArea("Main"));

            Series income = new Series("Доходи");
            income.ChartType = SeriesChartType.Column;

            Series expense = new Series("Витрати");
            expense.ChartType = SeriesChartType.Column;



            chart1.Series.Add(income);
            chart1.Series.Add(expense);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            chart1.Series.Clear();
            Series income = new Series("Доходи");
            income.ChartType = SeriesChartType.Column;
            income.Color = Color.Green;

            Series expense = new Series("Витрати");
            expense.ChartType = SeriesChartType.Column;
            expense.Color = Color.Red;
            for (DateTime d = start; d <= end; d = d.AddDays(1))
            {
                int incomes = (int)context.Incomes
                     .Where(x => x.CreatedAt >= d && x.CreatedAt < d.AddDays(1) && x.WalletId == wallet.Id)
                     .Select(x => x.Amount)
                     .Sum();

                int expenses = (int)context.Expenses
                    .Where(x => x.CreatedAt >= d && x.CreatedAt < d.AddDays(1) && x.WalletId == wallet.Id)
                    .Select(x => x.Amount)
                    .Sum();

                income.Points.AddXY(d.ToString("MM-dd"), incomes);
                expense.Points.AddXY(d.ToString("MM-dd"), expenses);
            }
            chart1.Series.Add(income);
            chart1.Series.Add(expense);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
