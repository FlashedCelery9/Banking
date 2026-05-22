namespace Banking
{
    partial class RegForm
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
            Nametxt = new TextBox();
            label1 = new Label();
            regbtn = new Button();
            label2 = new Label();
            passwordtxt = new TextBox();
            passeord2txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Emailtxt = new TextBox();
            SuspendLayout();
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(283, 95);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(125, 27);
            Nametxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // regbtn
            // 
            regbtn.Location = new Point(283, 325);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(94, 29);
            regbtn.TabIndex = 2;
            regbtn.Text = "Register";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 182);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(283, 205);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(125, 27);
            passwordtxt.TabIndex = 4;
            // 
            // passeord2txt
            // 
            passeord2txt.Location = new Point(283, 271);
            passeord2txt.Name = "passeord2txt";
            passeord2txt.Size = new Size(125, 27);
            passeord2txt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 248);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 129);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(283, 152);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(125, 27);
            Emailtxt.TabIndex = 7;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Emailtxt);
            Controls.Add(passeord2txt);
            Controls.Add(label3);
            Controls.Add(passwordtxt);
            Controls.Add(label2);
            Controls.Add(regbtn);
            Controls.Add(label1);
            Controls.Add(Nametxt);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nametxt;
        private Label label1;
        private Button regbtn;
        private Label label2;
        private TextBox passwordtxt;
        private TextBox passeord2txt;
        private Label label3;
        private Label label4;
        private TextBox Emailtxt;
    }
}