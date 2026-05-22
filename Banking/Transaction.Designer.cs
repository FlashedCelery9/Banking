namespace Banking
{
    partial class Transaction
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
            Category = new Label();
            createIncomebtn = new Button();
            Transact = new TabControl();
            Income = new TabPage();
            IncomeCategory = new ComboBox();
            button2 = new Button();
            IncomeAmount = new TextBox();
            label1 = new Label();
            Expense = new TabPage();
            ExpenseCategory = new ComboBox();
            button1 = new Button();
            ExpenseAmount = new TextBox();
            label2 = new Label();
            createExpensebtn = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Transact.SuspendLayout();
            Income.SuspendLayout();
            Expense.SuspendLayout();
            SuspendLayout();
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Category.Location = new Point(6, 50);
            Category.Name = "Category";
            Category.Size = new Size(86, 23);
            Category.TabIndex = 1;
            Category.Text = "Category";
            // 
            // createIncomebtn
            // 
            createIncomebtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            createIncomebtn.Location = new Point(6, 196);
            createIncomebtn.Name = "createIncomebtn";
            createIncomebtn.Size = new Size(94, 29);
            createIncomebtn.TabIndex = 2;
            createIncomebtn.Text = "Create";
            createIncomebtn.UseVisualStyleBackColor = true;
            createIncomebtn.Click += createIncomebtn_Click;
            // 
            // Transact
            // 
            Transact.Controls.Add(Income);
            Transact.Controls.Add(Expense);
            Transact.Location = new Point(12, 76);
            Transact.Name = "Transact";
            Transact.SelectedIndex = 0;
            Transact.Size = new Size(382, 368);
            Transact.TabIndex = 3;
            // 
            // Income
            // 
            Income.Controls.Add(IncomeCategory);
            Income.Controls.Add(button2);
            Income.Controls.Add(IncomeAmount);
            Income.Controls.Add(label1);
            Income.Controls.Add(createIncomebtn);
            Income.Controls.Add(Category);
            Income.Location = new Point(4, 29);
            Income.Name = "Income";
            Income.Padding = new Padding(3);
            Income.Size = new Size(374, 335);
            Income.TabIndex = 0;
            Income.Text = "Income";
            Income.UseVisualStyleBackColor = true;
            // 
            // IncomeCategory
            // 
            IncomeCategory.FormattingEnabled = true;
            IncomeCategory.Location = new Point(6, 76);
            IncomeCategory.Name = "IncomeCategory";
            IncomeCategory.Size = new Size(151, 28);
            IncomeCategory.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(106, 196);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // IncomeAmount
            // 
            IncomeAmount.Location = new Point(6, 137);
            IncomeAmount.Name = "IncomeAmount";
            IncomeAmount.Size = new Size(125, 27);
            IncomeAmount.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 114);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 4;
            label1.Text = "Amount";
            // 
            // Expense
            // 
            Expense.Controls.Add(label7);
            Expense.Controls.Add(label6);
            Expense.Controls.Add(label5);
            Expense.Controls.Add(textBox1);
            Expense.Controls.Add(ExpenseCategory);
            Expense.Controls.Add(button1);
            Expense.Controls.Add(ExpenseAmount);
            Expense.Controls.Add(label2);
            Expense.Controls.Add(createExpensebtn);
            Expense.Controls.Add(label3);
            Expense.Location = new Point(4, 29);
            Expense.Name = "Expense";
            Expense.Padding = new Padding(3);
            Expense.Size = new Size(374, 335);
            Expense.TabIndex = 1;
            Expense.Text = "Expense";
            Expense.UseVisualStyleBackColor = true;
            Expense.Click += button2_Click;
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.FormattingEnabled = true;
            ExpenseCategory.Location = new Point(6, 73);
            ExpenseCategory.Name = "ExpenseCategory";
            ExpenseCategory.Size = new Size(151, 28);
            ExpenseCategory.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(106, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // ExpenseAmount
            // 
            ExpenseAmount.Location = new Point(6, 131);
            ExpenseAmount.Name = "ExpenseAmount";
            ExpenseAmount.Size = new Size(125, 27);
            ExpenseAmount.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 108);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 9;
            label2.Text = "Amount";
            // 
            // createExpensebtn
            // 
            createExpensebtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            createExpensebtn.Location = new Point(6, 229);
            createExpensebtn.Name = "createExpensebtn";
            createExpensebtn.Size = new Size(94, 29);
            createExpensebtn.TabIndex = 7;
            createExpensebtn.Text = "Create";
            createExpensebtn.UseVisualStyleBackColor = true;
            createExpensebtn.Click += createExpensebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 47);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(203, 40);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 11;
            label4.Text = "________";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(218, 74);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 15;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(201, 139);
            label6.Name = "label6";
            label6.Size = new Size(158, 19);
            label6.TabIndex = 16;
            label6.Text = "If you send money to ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(230, 162);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 17;
            label7.Text = "another person";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 450);
            Controls.Add(label4);
            Controls.Add(Transact);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            Transact.ResumeLayout(false);
            Income.ResumeLayout(false);
            Income.PerformLayout();
            Expense.ResumeLayout(false);
            Expense.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Category;
        private Button createIncomebtn;
        private TabControl Transact;
        private TabPage Income;
        private TabPage Expense;
        private TextBox IncomeAmount;
        private Label label1;
        private TextBox ExpenseAmount;
        private Label label2;
        private Button createExpensebtn;
        private Label label3;
        private Button button2;
        private Button button1;
        private Label label4;
        private ComboBox IncomeCategory;
        private ComboBox ExpenseCategory;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
    }
}