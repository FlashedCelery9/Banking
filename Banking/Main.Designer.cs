namespace Banking
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            IncomeDataGrid = new DataGridView();
            label11 = new Label();
            panel5 = new Panel();
            expense = new Label();
            label6 = new Label();
            panel4 = new Panel();
            income = new Label();
            label5 = new Label();
            panel3 = new Panel();
            type = new Label();
            label4 = new Label();
            panel2 = new Panel();
            balance = new Label();
            label3 = new Label();
            label2 = new Label();
            Analyticsbtn = new Button();
            Transactionsbtn = new Button();
            walletscombobox = new ComboBox();
            label1 = new Label();
            Username = new Label();
            createWalletbtn = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDataGrid).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(IncomeDataGrid);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(347, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 511);
            panel1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.InactiveCaptionText;
            label7.Location = new Point(154, 473);
            label7.Name = "label7";
            label7.Size = new Size(99, 23);
            label7.TabIndex = 10;
            label7.Text = "Show more";
            label7.Click += label7_Click;
            label7.MouseEnter += label7_MouseEnter;
            label7.MouseLeave += label7_MouseLeave;
            // 
            // IncomeDataGrid
            // 
            IncomeDataGrid.BackgroundColor = SystemColors.ActiveCaption;
            IncomeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeDataGrid.Location = new Point(0, 282);
            IncomeDataGrid.Name = "IncomeDataGrid";
            IncomeDataGrid.RowHeadersWidth = 51;
            IncomeDataGrid.Size = new Size(412, 188);
            IncomeDataGrid.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(3, 249);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 8;
            label11.Text = "Transactions";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDarkDark;
            panel5.Controls.Add(expense);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(224, 166);
            panel5.Name = "panel5";
            panel5.Size = new Size(157, 80);
            panel5.TabIndex = 5;
            // 
            // expense
            // 
            expense.AutoSize = true;
            expense.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            expense.Location = new Point(45, 43);
            expense.Name = "expense";
            expense.Size = new Size(84, 28);
            expense.TabIndex = 8;
            expense.Text = "_________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(45, 10);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 2;
            label6.Text = "Expense";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(income);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(20, 166);
            panel4.Name = "panel4";
            panel4.Size = new Size(157, 80);
            panel4.TabIndex = 5;
            // 
            // income
            // 
            income.AutoSize = true;
            income.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            income.Location = new Point(40, 43);
            income.Name = "income";
            income.Size = new Size(84, 28);
            income.TabIndex = 8;
            income.Text = "_________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(42, 10);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 2;
            label5.Text = "Income";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(type);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(224, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 80);
            panel3.TabIndex = 4;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            type.Location = new Point(45, 39);
            type.Name = "type";
            type.Size = new Size(84, 28);
            type.TabIndex = 8;
            type.Text = "_________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(54, 9);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 2;
            label4.Text = "Type";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(balance);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 80);
            panel2.TabIndex = 3;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            balance.Location = new Point(40, 39);
            balance.Name = "balance";
            balance.Size = new Size(84, 28);
            balance.TabIndex = 7;
            balance.Text = "_________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(40, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(20, 27);
            label2.Name = "label2";
            label2.Size = new Size(53, 28);
            label2.TabIndex = 2;
            label2.Text = "Info";
            // 
            // Analyticsbtn
            // 
            Analyticsbtn.BackColor = SystemColors.ActiveBorder;
            Analyticsbtn.FlatStyle = FlatStyle.Flat;
            Analyticsbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Analyticsbtn.Location = new Point(12, 366);
            Analyticsbtn.Name = "Analyticsbtn";
            Analyticsbtn.Size = new Size(191, 58);
            Analyticsbtn.TabIndex = 10;
            Analyticsbtn.Text = "Analytics";
            Analyticsbtn.UseVisualStyleBackColor = false;
            Analyticsbtn.Click += Analyticsbtn_Click;
            // 
            // Transactionsbtn
            // 
            Transactionsbtn.BackColor = SystemColors.ActiveBorder;
            Transactionsbtn.FlatStyle = FlatStyle.Flat;
            Transactionsbtn.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Transactionsbtn.Location = new Point(12, 279);
            Transactionsbtn.Name = "Transactionsbtn";
            Transactionsbtn.Size = new Size(191, 59);
            Transactionsbtn.TabIndex = 9;
            Transactionsbtn.Text = "Transaction";
            Transactionsbtn.UseVisualStyleBackColor = false;
            Transactionsbtn.Click += Transactionsbtn_Click;
            // 
            // walletscombobox
            // 
            walletscombobox.FormattingEnabled = true;
            walletscombobox.Location = new Point(22, 116);
            walletscombobox.Name = "walletscombobox";
            walletscombobox.Size = new Size(148, 28);
            walletscombobox.TabIndex = 8;
            walletscombobox.SelectedIndexChanged += SelectWallet;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 73);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Wallets";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Username.Location = new Point(12, 9);
            Username.Name = "Username";
            Username.Size = new Size(86, 35);
            Username.TabIndex = 6;
            Username.Text = "Name";
            // 
            // createWalletbtn
            // 
            createWalletbtn.BackColor = SystemColors.ActiveBorder;
            createWalletbtn.FlatStyle = FlatStyle.Flat;
            createWalletbtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            createWalletbtn.Location = new Point(33, 157);
            createWalletbtn.Name = "createWalletbtn";
            createWalletbtn.Size = new Size(137, 36);
            createWalletbtn.TabIndex = 12;
            createWalletbtn.Text = "CreateWallet";
            createWalletbtn.UseVisualStyleBackColor = false;
            createWalletbtn.Click += createWalletbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(33, 207);
            button1.Name = "button1";
            button1.Size = new Size(137, 36);
            button1.TabIndex = 13;
            button1.Text = "EditWallet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 506);
            Controls.Add(button1);
            Controls.Add(createWalletbtn);
            Controls.Add(panel1);
            Controls.Add(Analyticsbtn);
            Controls.Add(Transactionsbtn);
            Controls.Add(walletscombobox);
            Controls.Add(label1);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDataGrid).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView IncomeDataGrid;
        private Label label11;
        private Panel panel5;
        private Label expense;
        private Label label6;
        private Panel panel4;
        private Label income;
        private Label label5;
        private Panel panel3;
        private Label type;
        private Label label4;
        private Panel panel2;
        private Label balance;
        private Label label3;
        private Label label2;
        private Button Analyticsbtn;
        private Button Transactionsbtn;
        private ComboBox walletscombobox;
        private Label label1;
        private Label Username;
        private Button createWalletbtn;
        private Label label7;
        private Button button1;
    }
}